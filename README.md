# CleanArchitecture1.5.0

<p align="center">
  <a href="#zh-cn"><button>中文说明</button></a>
  <a href="#en"><button>English</button></a>
</p>

---

## <span id="zh-cn">🧩 项目简介（中文）</span>

这是一个基于 .NET 9.0 的 ASP.NET Core WebAPI 清晰架构（Clean Architecture）通用模板，由本人自研，适合企业级/个人项目的快速开发和最佳实践。

### 🚀 技术栈
- **.NET 9.0**
- **ASP.NET Core WebAPI**
- **Clean Architecture 分层结构**（Domain, Application, Infrastructure, API）
- **Entity Framework Core 9**（支持SQL Server）
- **MongoDB.Driver**（支持MongoDB）
- **AutoMapper**（对象映射）
- **MediatR**（中介者模式/CQRS）
- **FluentValidation**（请求验证）
- **Serilog**（结构化日志）
- **JWT Bearer认证** & **Identity**（用户认证与授权）
- **MailKit**（邮件发送）
- **QRCoder**（二维码生成）
- **腾讯云COS SDK**（云存储）
- **Swagger/Swashbuckle**（API文档，访问路径：`/swagger`）

### 🌟 主要特性
- 完全分层，关注点分离，易于扩展和维护
- 支持多数据库（SQL Server、MongoDB）
- 集成Swagger，开箱即用API文档
- 支持JWT认证、角色权限、邮件、云存储、二维码等常用功能
- 代码风格统一，适合二次开发

---

## <span id="en">🧩 Project Introduction (English)</span>

This is a self-developed, general-purpose Clean Architecture template for ASP.NET Core WebAPI based on .NET 9.0. It is suitable for enterprise and personal projects, enabling rapid development and best practices.

### 🚀 Tech Stack
- **.NET 9.0**
- **ASP.NET Core WebAPI**
- **Clean Architecture** (Domain, Application, Infrastructure, API)
- **Entity Framework Core 9** (SQL Server supported)
- **MongoDB.Driver** (MongoDB supported)
- **AutoMapper** (object mapping)
- **MediatR** (CQRS/Mediator pattern)
- **FluentValidation** (request validation)
- **Serilog** (structured logging)
- **JWT Bearer & Identity** (authentication & authorization)
- **MailKit** (email sending)
- **QRCoder** (QR code generation)
- **Tencent Cloud COS SDK** (cloud storage)
- **Swagger/Swashbuckle** (API docs, visit `/swagger`)

### 🌟 Main Features
- Fully layered, separation of concerns, easy to extend and maintain
- Multi-database support (SQL Server, MongoDB)
- Built-in Swagger API documentation
- JWT authentication, role/permission, email, cloud storage, QR code, and more
- Unified code style, suitable for secondary development

---

> 点击上方按钮可切换中英文说明 | Click the buttons above to switch language.