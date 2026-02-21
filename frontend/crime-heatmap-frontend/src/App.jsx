import { useEffect, useState } from "react";
import {
  MapContainer,
  TileLayer,
  Marker,
  Popup,
  useMap,
} from "react-leaflet";
import axios from "axios";
import L from "leaflet";
import "leaflet.heat";
import "leaflet/dist/leaflet.css";

// 🔧 Fix missing marker icons in Vite/React
import markerIcon2x from "leaflet/dist/images/marker-icon-2x.png";
import markerIcon from "leaflet/dist/images/marker-icon.png";
import markerShadow from "leaflet/dist/images/marker-shadow.png";

delete L.Icon.Default.prototype._getIconUrl;
L.Icon.Default.mergeOptions({
  iconUrl: markerIcon,
  iconRetinaUrl: markerIcon2x,
  shadowUrl: markerShadow,
});

// 🔥 Heatmap Layer
function HeatmapLayer({ points }) {
  const map = useMap();

  useEffect(() => {
    if (!points || points.length === 0) return;

    const heatLayer = L.heatLayer(points, {
      radius: 50,
      blur: 30,
      maxZoom: 17,
      max: 1.0,
      gradient: {
        0.2: "blue",
        0.4: "lime",
        0.6: "yellow",
        0.8: "orange",
        1.0: "red",
      },
    }).addTo(map);

    return () => {
      map.removeLayer(heatLayer);
    };
  }, [points, map]);

  return null;
}

// 🧭 Fly to specific crime
function FlyToCrime({ crime }) {
  const map = useMap();

  useEffect(() => {
    if (crime) {
      map.flyTo([crime.latitude, crime.longitude], 16, {
        animate: true,
        duration: 2,
      });
    }
  }, [crime, map]);

  return null;
}

function App() {
  const [heatPoints, setHeatPoints] = useState([]);
  const [crime, setCrime] = useState(null);

  useEffect(() => {
    // 🔹 Fetch heatmap data
    axios
      .get("https://localhost:7198/api/Crimes/heatmap")
      .then((res) => {
        const formatted = res.data.map((p) => [p.lat, p.lng, p.weight]);
        setHeatPoints(formatted);
      })
      .catch((err) => console.error("HEATMAP API ERROR:", err));

    // 🔹 Fetch specific crime by ID
    axios
      .get("https://localhost:7198/api/Crimes/1")
      .then((res) => {
        setCrime(res.data);
      })
      .catch((err) => console.error("CRIME API ERROR:", err));
  }, []);

  return (
    <MapContainer
      center={[17.385, 78.4867]}
      zoom={13}
      style={{ height: "100vh", width: "100%" }}
    >
      <TileLayer
        attribution="&copy; OpenStreetMap contributors"
        url="https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png"
      />

      <HeatmapLayer points={heatPoints} />
      {crime && <FlyToCrime crime={crime} />}

      {/* 📍 Marker for the specific crime */}
      {crime && (
        <Marker position={[crime.latitude, crime.longitude]}>
          <Popup>
            <strong>{crime.title}</strong>
            <br />
            {crime.description}
            <br />
            <em>{crime.address}</em>
          </Popup>
        </Marker>
      )}
    </MapContainer>
  );
}

export default App;