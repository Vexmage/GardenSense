# GardenSense 🌿

**Simulated greenhouse monitoring dashboard built with Blazor Server and EF Core.**

GardenSense is a Blazor-based project that simulates an intelligent environment control system for home gardens or small-scale greenhouses. It was inspired by a conversation with an acquaintance who was exploring the idea of using Raspberry Pi sensors and relays to control temperature and lighting in their garden setup.

> While that collaboration never quite took off — due to time and budget constraints — I decided to carry the project forward and build it out as a standalone system. This version simulates real-world functionality using realistic generated data, letting me explore smart environmental controls, data visualization, and full-stack architecture without relying on hardware.

The result is a dashboard that tracks temperature, humidity, soil moisture, and light levels per garden zone, with simulated controls for heaters, fans, and grow lights. It’s a fun, meaningful project that blends environmental technology, software engineering, and personal curiosity.

---

## 🔧 Tech Stack

- **Blazor Server (.NET 8)**
- **Entity Framework Core** with SQLite
- **Bootstrap 5 UI ** with responsive layout
- **Custom sensor simulation service**
- Future: **Charting** with ChartJS.Blazor or Blazorise

---

## 🌱 Features

- 📍 **Zone Management** -- Define garden zones and locations
- 🧪 **Sensor Simulation** — Generate realistic temperature, humidity, light, and soil moisture data
- 📊 **History Viewer** — Browse time-series data for each zone
- 🖥️ **Admin Dashboard** — Clean landing page with contextual navigation
- 🔧 **Fully database-driven** with async EF Core operations


---

## ✨ Highlights
- **Simulates real-world control logic** with realistic sensor variance
- Built for **growth**: future plans include GPIO mockups, actuator toggling, and charting
- Clean architecture with **separation** of concerns (Services, Pages, Data, Models)

---

## 📸 Screenshots

_(Coming soon as the UI is built out.)_

---

## 🚀 Status

✅ Project scaffolded  
✅ EF Core models and DB setup  
🔜 CRUD for zones  
🔜 Simulated data service  
🔜 Dashboard with charts  
🔜 Control panel and history views

---

## 🧑‍💻 Author

**Joel Southall**  
[greatlynxdesigns.com](https://greatlynxdesigns.com)  
[GitHub](https://github.com/vexmage) · [LinkedIn](https://linkedin.com/in/joelmaxsouthall)  
