# CloudQA Automation Task

![Build](https://github.com/Sahanap1708/CloudQATask/actions/workflows/dotnet.yml/badge.svg)
[![Build Status](https://img.shields.io/badge/build-passing-brightgreen)](https://github.com/Sahanap1708/CloudQATask)
[![Language](https://img.shields.io/badge/language-C%23-blue)](https://docs.microsoft.com/dotnet/csharp/)
[![Selenium Version](https://img.shields.io/badge/Selenium-4.25.0-orange)](https://www.selenium.dev/)
[![NUnit Version](https://img.shields.io/badge/NUnit-3.13.3-red)](https://nunit.org/)

---

## Project Overview
Automated UI tests for the **CloudQA Automation Practice Form** using **C#, Selenium WebDriver, and NUnit**.  

**Tested Fields:**
1. Name field – enter text and verify input  
2. Email field – enter text and verify input  
3. Gender selection – select a radio button  

Tests are designed to remain **stable even if element IDs or page structure change**, using robust selectors and wait conditions.

**Demo URL:** [CloudQA Practice Form](https://app.cloudqa.io/home/AutomationPracticeForm)

---

## Tech Stack
| Tool | Version |
|------|---------|
| .NET SDK | 10.0 |
| C# | Latest |
| Selenium WebDriver | 4.25.0 |
| Selenium Support | 4.25.0 |
| NUnit | 3.13.3 |
| NUnit3TestAdapter | 4.5.0 |

---

## Project Structure
cloudqatask/
│
└── testcases/
├── AutomationPracticeFormTests.cs
├── testcases.csproj
├── appsettings.json
└── README.md


---

## How to Run Tests

1️⃣ Restore and build:
bash
dotnet clean
dotnet restore
dotnet build


2️⃣ Run tests:

dotnet test


Expected output:

Test summary: total: 3, failed: 0, succeeded: 3


Selenium Driver Setup

Selenium automatically uses Selenium Manager, no manual ChromeDriver download required.

Chrome version is auto-detected and the correct driver is downloaded automatically.


Notes

Tests are independent and self-contained.

Designed to work even after minor UI or DOM changes.

Optimized for readability and maintainability.


Author

Sahana P
C# | Selenium | Automation Testing
CloudQA Internship Task


---



