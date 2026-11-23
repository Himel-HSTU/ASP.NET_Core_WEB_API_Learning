# ASP.NET Core Web API — Engineering & Implementation

![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Blazor](https://img.shields.io/badge/Blazor-512BD4?style=for-the-badge&logo=blazor&logoColor=white)
![Swagger](https://img.shields.io/badge/OpenAPI%20%2F%20Swagger-85EA2D?style=for-the-badge&logo=swagger&logoColor=black)
![Postman](https://img.shields.io/badge/Postman-FF6C37?style=for-the-badge&logo=postman&logoColor=white)
![Status](https://img.shields.io/badge/Progress-~60%25%20Complete-blue?style=for-the-badge)

Building a strong foundation in **Backend Engineering with C# and ASP.NET Core** through practical learning, experimentation, and implementation.

This repository documents my journey of learning ASP.NET Core Web API, covering everything from REST API fundamentals to building, securing, monitoring, and consuming real-world APIs.

Moving well beyond basic CRUD scaffolding, the focus is on understanding the broader engineering principles behind modern APIs — including identity and access control, API lifecycle management and versioning, observability, resilience, decoupled architecture, and full-stack client integration.

The goal is not just to understand how APIs work, but to develop the knowledge and practical skills required to design and build **reliable, maintainable, secure, and well-structured backend services.**

---

## Tech Stack & Tooling

| Domain | Technologies & Concepts |
| :--- | :--- |
| **Backend & Architecture** | C#, ASP.NET Core Web API, Minimal APIs, Decoupled Class Libraries, Data Access Layer |
| **Client Integration** | Blazor (`HttpClient`), OpenAPI-Generated Client SDKs |
| **Security & Governance** | Token-Based Authentication, Claims & Policy-Based Authorization, Secret Management, Input Validation |
| **Observability & Resilience** | Structured Logging, Health Checks, Real-Time Monitoring, Response Caching, Rate Limiting |
| **Documentation & QA** | OpenAPI / Swagger UI (XML Comments, Auth Support, Custom CSS Themes), API Versioning, Postman |

---
## 🎯 What I'm Learning
 
### 🧱 1. Foundations
- What an API is, when to use one, and how **REST** shapes API design
- Where ASP.NET Core fits in the picture
- Creating a project, project setup and cleanup
- Controllers, routing, and **HTTP verbs** (GET, POST, PUT, DELETE)
- Adding API capabilities to an existing project
### 🧪 2. Testing & Documentation
- Testing through the browser, **Swagger / OpenAPI** and **Postman**
- Customizing Swagger: serving it at the root, XML comments, custom themes
- Supporting both OpenAPI 2 and 3, and enabling authentication inside Swagger UI
### 🔐 3. Security
- Keeping secrets out of source code
- Creating and validating **tokens (JWT)**
- Authentication vs authorization
- **Claims-based** and advanced policy-based authorization
- Secure-by-default API design
### 🔀 4. Versioning
- Configuring an API versioning library
- Implementing multiple versions side by side
- Making Swagger version-aware
- Deprecating old versions gracefully
- Version-neutral endpoints
### 📡 5. Monitoring
- Structured **logging**
- **Health checks** (and exposing them as endpoints)
- Real-time monitoring of a running API
### 🛡️ 6. Protecting the API
- **Data validation** at the edge
- **Caching** to cut unnecessary work
- **Rate limiting** to stop abuse
### 🏗️ 7. Building a Real API End to End
- Designing the API before writing it
- Separating concerns with a **class library** + API project
- Controllers, database creation, data access and wiring it all together
- Basic security, health checks and logging in a real project
- Testing the finished API
### 🖥️ 8. Consuming an API
- Building a **Blazor** client
- Wiring up `HttpClient`
- Login flow and displaying data from the API
- Using an OpenAPI-generated client as an alternative
### ⚡ 9. Minimal APIs
- Creating endpoints without controllers
- Moving from sample endpoints to real ones
- Securing a Minimal API
### ✅ 10. API Best Practices
- Consistency and good naming
- Standard HTTP status codes
- Pagination
- Health check endpoints
- Documenting endpoints properly
---
## What's Inside & Learning Roadmap

### 1. RESTful Architecture & Core API Foundations
- [x] **API & REST Principles:** Resource-oriented design, architectural constraints, and ASP.NET Core's role in modern backend systems
- [x] **Service Scaffolding & Routing:** Clean project structure, Controller-based architecture, standard HTTP verb semantics, and embedding Web APIs into existing .NET solutions
- [x] **Verification Workflows:** Systematic endpoint validation across browser tooling, interactive OpenAPI UI, and Postman

### 2. API Security, Identity & Resilience
- [x] **Configuration Hygiene:** Secure secret management and environment-safe credential storage
- [x] **Authentication & Access Control:** Token issuance, custom claims design, and fine-grained authorization policies
- [x] **Contract Integrity:** Strict server-side request validation to guard API boundaries
- [x] **Performance & Traffic Protection:** Response caching for latency optimization and rate limiting/throttling to defend against abuse and traffic spikes

### 3. API Lifecycle Management & Observability
- [x] **Versioning & Evolution:** Multi-version API routing, version-aware Swagger configuration, graceful deprecation workflows, and version-neutral endpoints
- [x] **Diagnostics & Telemetry:** Structured logging pipelines for troubleshooting and audit trails
- [x] **Operational Readiness:** Health check endpoints and real-time service monitoring

### 4. End-to-End Implementation & Client Consumption
- [ ] **Layered Service Architecture:** Designing a full-featured API backed by isolated Class Libraries, a dedicated Data Access layer, and relational database provisioning
- [ ] **Production Wiring:** Combining controllers, persistence, security, logging, and health probes into a cohesive backend service
- [ ] **Blazor Client Integration:** Consuming secured endpoints via `HttpClient` with full authentication flows and stateful CRUD operations
- [ ] **Automated Client Tooling:** Generating strongly typed API clients directly from OpenAPI specifications

### 5. Advanced OpenAPI, Minimal APIs & Industry Standards
- [ ] **Enterprise Swagger Customization:** Root-level documentation hosting, OpenAPI 2 support, XML documentation extraction, Swagger authentication wiring, and custom CSS theming
- [ ] **Lightweight Services:** Designing, routing, and securing high-performance **Minimal APIs**
- [ ] **Production Best Practices:** Consistent resource naming, standard HTTP status code semantics, pagination, secure-by-default architecture, and self-documenting contracts

---

## Core Engineering Principles

What separates a sample endpoint from an enterprise service is everything surrounding the business logic. This repository is built around four pillars:

- **Separation of Concerns:** Keeping controllers thin by isolating business logic and data access into reusable Class Libraries.
- **Defense in Depth:** Layering token/claims security with strict input validation, secret hygiene, and rate limiting.
- **Developer Experience (DX):** Treating API documentation as a first-class artifact through enriched OpenAPI specs, XML comments, and predictable versioning.
- **Observability First:** Baking in structured logging, health checks, and real-time monitoring from day one.

---
## 🙏 Credits
 
Learning material based on Tim Corey's ASP.NET Core Web API course. All code in this repository is my own practice work and notes while following along and experimenting.
<div align="center">

## Author

### **Habibur Rahman Himel**
*Aspiring .NET Backend & Full-Stack Software Engineer — Focused on C#, ASP.NET Core, Blazor & Clean Architecture*

[![Portfolio](https://img.shields.io/badge/Portfolio-himelrahman.pages.dev-512BD4?style=for-the-badge&logo=cloudflarepages&logoColor=white)](https://himelrahman.pages.dev)
[![GitHub](https://img.shields.io/badge/GitHub-@Himel--HSTU-181717?style=for-the-badge&logo=github&logoColor=white)](https://github.com/Himel-HSTU)

</div>
