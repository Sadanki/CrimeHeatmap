<div align="center">

# 🔥 CrimeHeatmap

### *Visualize Crime. Understand Patterns. Build Safer Cities.*

[![Made with Python](https://img.shields.io/badge/Backend-Python-3776AB?style=for-the-badge&logo=python&logoColor=white)](https://python.org)
[![React](https://img.shields.io/badge/Frontend-React-61DAFB?style=for-the-badge&logo=react&logoColor=black)](https://reactjs.org)
[![Docker](https://img.shields.io/badge/Deployed-Docker-2496ED?style=for-the-badge&logo=docker&logoColor=white)](https://docker.com)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow?style=for-the-badge)](LICENSE)
[![GitHub Stars](https://img.shields.io/github/stars/Sadanki/CrimeHeatmap?style=for-the-badge&color=orange)](https://github.com/Sadanki/CrimeHeatmap/stargazers)

<br/>

> **Turn raw crime data into actionable geographic intelligence.**  
> An end-to-end full-stack platform that ingests crime records, processes them through a Python backend, and renders interactive real-time heatmaps on a React frontend — built for analysts, researchers, and smart-city architects.

<br/>

![CrimeHeatmap Banner](https://capsule-render.vercel.app/api?type=waving&color=gradient&customColorList=6,11,20&height=180&section=header&text=CrimeHeatmap&fontSize=60&fontColor=fff&animation=twinkling&fontAlignY=35&desc=Real-Time%20Crime%20Visualization%20Platform&descAlignY=60&descSize=18)

</div>

---

## 📸 Preview

<div align="center">

| 🗺️ Live Heatmap View | 📊 Analytics Dashboard |
|:---:|:---:|
| *Interactive crime density map* | *Trend charts & filters* |

</div>

---

## ⚡ Features

```
🗺️  Interactive Heatmap       →  Zoom, pan, and filter crime clusters in real-time
📡  Live Data Ingestion        →  REST API backend that accepts & stores crime reports
🔍  Filter by Crime Type       →  Drill down by category, date range, or severity
📊  Analytics Dashboard        →  Charts, stats, and trend analysis at a glance
🌙  Dark Mode UI               →  Sleek, modern interface built for long sessions
🐳  Dockerized Deployment      →  One command to spin up the entire stack
🔐  Secure API Layer           →  Input validation, CORS, and error handling baked in
📱  Responsive Design          →  Works flawlessly on desktop, tablet, and mobile
```

---

## 🏗️ Architecture

```
CrimeHeatmap/
│
├── 🖥️  backend/                  # Python REST API
│   ├── app.py                   # Main Flask/FastAPI application
│   ├── routes/                  # API endpoint definitions
│   ├── models/                  # Data models & schemas
│   ├── services/                # Business logic layer
│   └── requirements.txt         # Python dependencies
│
├── 🌐  frontend/                 # React Application
│   ├── src/
│   │   ├── components/          # Reusable UI components
│   │   │   ├── HeatMap.jsx      # Core map visualization component
│   │   │   ├── Dashboard.jsx    # Analytics dashboard
│   │   │   └── Filters.jsx      # Crime type & date filters
│   │   ├── pages/               # Route-level views
│   │   ├── hooks/               # Custom React hooks
│   │   ├── api/                 # Axios API client
│   │   └── App.jsx              # Root component
│   └── package.json
│
├── 🐳  docker-compose.yml        # Full-stack orchestration
└── 📖  README.md
```

---

## 🚀 Quick Start

### Prerequisites

```bash
# Make sure you have these installed
node >= 18.x
python >= 3.10
docker & docker-compose   # (optional, for containerized setup)
```

### 🐳 Option 1 — Docker (Recommended)

```bash
# Clone the repo
git clone https://github.com/Sadanki/CrimeHeatmap.git
cd CrimeHeatmap

# Spin up the full stack in one shot
docker-compose up --build
```

> 🎉 Frontend → `http://localhost:3000` | Backend API → `http://localhost:8000`

---

### 🔧 Option 2 — Manual Setup

**Backend**
```bash
cd backend
python -m venv venv
source venv/bin/activate        # Windows: venv\Scripts\activate
pip install -r requirements.txt
python app.py
```

**Frontend**
```bash
cd frontend
npm install
npm start
```

---

## 🔌 API Reference

| Method | Endpoint | Description |
|--------|----------|-------------|
| `GET` | `/api/crimes` | Fetch all crime records |
| `GET` | `/api/crimes?type=theft&from=2024-01-01` | Filter by type & date |
| `POST` | `/api/crimes` | Submit a new crime report |
| `GET` | `/api/crimes/stats` | Aggregated stats & heatmap data |
| `GET` | `/api/health` | Health check |

<details>
<summary><strong>📦 Sample API Response</strong></summary>

```json
{
  "status": "success",
  "count": 1423,
  "data": [
    {
      "id": "CR-20240315-001",
      "type": "Theft",
      "severity": "medium",
      "lat": 17.3850,
      "lng": 78.4867,
      "timestamp": "2024-03-15T14:23:00Z",
      "location": "Hyderabad, Telangana"
    }
  ]
}
```

</details>

---

## 🛠️ Tech Stack

<div align="center">

| Layer | Technology |
|-------|-----------|
| **Frontend** | React, Leaflet.js / Mapbox GL, Recharts, Axios |
| **Backend** | Python, Flask / FastAPI |
| **Database** | PostgreSQL / SQLite |
| **DevOps** | Docker, Docker Compose, GitHub Actions |
| **Styling** | Tailwind CSS / CSS Modules |

</div>

---

## 🗺️ Roadmap

- [x] Project scaffolding (backend + frontend)
- [ ] Core REST API endpoints
- [ ] Heatmap rendering with Leaflet
- [ ] Crime category filters
- [ ] Analytics dashboard
- [ ] User authentication
- [ ] Real-time data via WebSockets
- [ ] CI/CD pipeline with GitHub Actions
- [ ] Cloud deployment (AWS / Azure)
- [ ] Mobile PWA support

---

## 🤝 Contributing

Contributions are what make open source amazing! Here's how to get involved:

```bash
# 1. Fork the repo
# 2. Create your feature branch
git checkout -b feature/amazing-feature

# 3. Commit your changes
git commit -m "feat: add amazing feature"

# 4. Push and open a PR
git push origin feature/amazing-feature
```

Please read [CONTRIBUTING.md](CONTRIBUTING.md) before submitting pull requests.

---

## 📄 License

Distributed under the **MIT License**. See [`LICENSE`](LICENSE) for more information.

---

## 👨‍💻 Author

<div align="center">

<img src="https://avatars.githubusercontent.com/u/165776478?v=4" width="100" style="border-radius:50%"/>

**Vignesh Sadanake**  
*DevOps & Cloud Engineer · Python Enthusiast · Open Source Builder*

[![GitHub](https://img.shields.io/badge/GitHub-Sadanki-181717?style=flat-square&logo=github)](https://github.com/Sadanki)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-Vignesh_Sadanake-0077B5?style=flat-square&logo=linkedin)](https://www.linkedin.com/in/vignesh-sadankae-1866b5218/)
[![Email](https://img.shields.io/badge/Email-vignesh.sadankae@gmail.com-D14836?style=flat-square&logo=gmail&logoColor=white)](mailto:vignesh.sadankae@gmail.com)

</div>

---

<div align="center">

**If this project helped you, drop a ⭐ — it means the world!**

![Visitor Count](https://komarev.com/ghpvc/?username=Sadanki&label=Profile+Views&color=red&style=flat-square)

*Built with ❤️ from Hyderabad, India 🇮🇳*

</div>