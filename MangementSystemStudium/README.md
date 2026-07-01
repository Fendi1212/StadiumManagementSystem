# 🏟️ ArenaPulse — Next-Generation Stadium & Event Management Platform

Welcome to **ArenaPulse**, a robust, production-ready enterprise management platform designed to streamline high-capacity venue operations, coordinate real-time sports fixtures, manage ticket inventory, and enforce strict administrative access controls.

Built using **ASP.NET MVC 5**, **Entity Framework Code-First**, and **.NET Identity Security Framework**.

---

## 🚀 Key System Features

* **📊 Premium Administrative Dashboard:** A completely custom, modern data interface displaying operational metrics, systemic statuses, and live tracking utilities.
* **🔍 Dynamic Backend LINQ Filter Engine:** Integrated text search fields mapping multi-column queries across match titles, stadium names, and locations simultaneously.
* **⚙️ Full Database CRUD Lifecycles:** Secure, structured event scheduling operations allowing complete data creation, editing, structural updates, and safety removal actions.
* **🔐 Integrated Identity Guardrails:** Protected backend controllers utilizing role-based access tokens to insulate sensitive stadium operations from unauthorized entities.

---

## 🛠️ Technology Stack & Architecture

* **Framework:** ASP.NET MVC 5 (.NET Framework 4.7+)
* **Data Layer:** Entity Framework 6 (Code-First Migrations)
* **Database:** Microsoft SQL Server LocalDB
* **Security:** Microsoft ASP.NET Identity Framework
* **Front-End UI:** Bootstrap 3 layout with injection inline CSS dashboard components

```csharp
// Sample: The dynamic backend search architecture implementation
var events = from e in db.Events select e;
if (!String.IsNullOrEmpty(searchString))
{
    events = events.Where(s => s.Title.Contains(searchString) || s.Venue.Contains(searchString));
}