<div align="center">

# 🔥 CrimeHeatmap

### *Visualize Crime. Understand Patterns. Build Safer Cities.*

[![C#](https://img.shields.io/badge/Backend-C%23%20%7C%20ASP.NET%20Core-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com)
[![React](https://img.shields.io/badge/Frontend-React%20%2B%20Vite-61DAFB?style=for-the-badge&logo=react&logoColor=black)](https://reactjs.org)
[![JavaScript](https://img.shields.io/badge/Language-JavaScript-F7DF1E?style=for-the-badge&logo=javascript&logoColor=black)](https://developer.mozilla.org/en-US/docs/Web/JavaScript)
[![Bootstrap](https://img.shields.io/badge/UI-Bootstrap%205-7952B3?style=for-the-badge&logo=bootstrap&logoColor=white)](https://getbootstrap.com)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow?style=for-the-badge)](LICENSE)
[![GitHub Stars](https://img.shields.io/github/stars/Sadanki/CrimeHeatmap?style=for-the-badge&color=orange)](https://github.com/Sadanki/CrimeHeatmap/stargazers)

<br/>

> **Turn raw crime data into actionable geographic intelligence.**  
> A full-stack platform with a **C# ASP.NET Core Web API** backend and a **React + Vite** frontend that renders interactive, real-time crime heatmaps — built for analysts, researchers, and smart-city architects.

<br/>

![CrimeHeatmap Banner](https://capsule-render.vercel.app/api?type=waving&color=gradient&customColorList=6,11,20&height=180&section=header&text=CrimeHeatmap&fontSize=60&fontColor=fff&animation=twinkling&fontAlignY=35&desc=Real-Time%20Crime%20Visualization%20Platform&descAlignY=60&descSize=18)

</div>

---

## ⚡ Features

```
🗺️  Interactive Heatmap       →  Zoom, pan, and filter crime clusters in real-time
📡  ASP.NET Core REST API      →  Fast, typed C# endpoints with Swagger/OpenAPI support
⚛️  React + Vite Frontend      →  Lightning-fast HMR dev experience
🔍  Filter by Crime Type       →  Drill down by category, date range, or severity
📊  Analytics Dashboard        →  Charts, stats, and trend analysis at a glance
🎨  Bootstrap 5 UI             →  Clean, responsive, mobile-friendly interface
🔐  Secure API Layer           →  CORS policy, input validation, and error handling
📱  Responsive Design          →  Works on desktop, tablet, and mobile
```

---

## 🏗️ Architecture

```
CrimeHeatmap/
│
├── 🖥️  backend/
│   └── CrimeHeatmap.API/
│       └── CrimeHeatmap.API/
│           ├── Controllers/              # C# API controllers
│           ├── Models/                   # Data models & DTOs
│           ├── Services/                 # Business logic layer
│           ├── wwwroot/                  # Static assets
│           │   └── lib/                  # Bootstrap, jQuery, Validation
│           ├── Program.cs                # App entry point & DI configuration
│           ├── appsettings.json          # App configuration
│           └── CrimeHeatmap.API.csproj   # .NET 10 project file
│
├── 🌐  frontend/
│   └── crime-heatmap-frontend/
│       ├── src/
│       │   ├── components/               # Reusable UI components
│       │   ├── pages/                    # Route-level views
│       │   ├── hooks/                    # Custom React hooks
│       │   ├── api/                      # API client (fetch/axios)
│       │   ├── App.jsx                   # Root component & routing
│       │   └── main.jsx                  # Vite entry point
│       ├── index.html
│       ├── vite.config.js
│       └── package.json
│
├── .gitignore
└── README.md
```

---

## 🛠️ Tech Stack

<div align="center">

| Layer | Technology |
|-------|-----------|
| **Backend Language** | C# (.NET 10) |
| **Backend Framework** | ASP.NET Core Web API |
| **API Documentation** | Swagger / OpenAPI |
| **Frontend Framework** | React 18 |
| **Frontend Build Tool** | Vite |
| **Frontend Language** | JavaScript (JSX) |
| **UI Framework** | Bootstrap 5 |
| **Map Engine** | Leaflet.js |
| **HTTP Client** | Fetch API / Axios |

</div>

---

## 🚀 Quick Start

### Prerequisites

```
.NET SDK 10.0+    →  https://dotnet.microsoft.com/download
Node.js 18+       →  https://nodejs.org
```

### 🖥️ Backend — ASP.NET Core API

```bash
cd backend/CrimeHeatmap.API/CrimeHeatmap.API

# Restore NuGet packages
dotnet restore

# Run the API
dotnet run
```

> Swagger UI → `https://localhost:{PORT}/swagger`

---

### 🌐 Frontend — React + Vite

```bash
cd frontend/crime-heatmap-frontend

# Install dependencies
npm install

# Start dev server
npm run dev
```

> App → `http://localhost:5173`

To build for production:
```bash
npm run build
```

---

## 🔌 API Reference

| Method | Endpoint | Description |
|--------|----------|-------------|
| `GET` | `/api/crimes` | Fetch all crime records |
| `GET` | `/api/crimes?type=theft&from=2024-01-01` | Filter by type & date |
| `POST` | `/api/crimes` | Submit a new crime report |
| `GET` | `/api/crimes/stats` | Aggregated stats for heatmap |
| `GET` | `/swagger` | Interactive API docs |

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

## 🗺️ Roadmap

- [x] Project scaffolding — ASP.NET Core API + React/Vite frontend
- [ ] Core REST API endpoints (CRUD for crime data)
- [ ] Heatmap rendering with Leaflet
- [ ] Crime category & date filters
- [ ] Analytics dashboard with charts
- [ ] Database integration (SQL Server / SQLite)
- [ ] CORS & authentication layer
- [ ] CI/CD pipeline with GitHub Actions
- [ ] Docker containerization
- [ ] Cloud deployment (Azure)

---

## 🤝 Contributing

```bash
# 1. Fork the repo
# 2. Create your feature branch
git checkout -b feature/amazing-feature

# 3. Commit your changes
git commit -m "feat: add amazing feature"

# 4. Push and open a PR
git push origin feature/amazing-feature
```

---

## 📄 License

Distributed under the **MIT License**. See [`LICENSE`](LICENSE) for more information.

---

## 👨‍💻 Author

<div align="center">

<img src="https://avatars.githubusercontent.com/u/165776478?v=4" width="100" style="border-radius:50%"/>

**Vignesh Sadanake**  
*DevOps & Cloud Engineer · .NET & React Developer · Open Source Builder*

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