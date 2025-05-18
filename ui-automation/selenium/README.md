# 🎮 UI Automation Scripts

This section contains tools and scripts that automate user interface actions across web applications using popular automation frameworks.

Whether you're automating login flows, form submissions, or entire E2E flows, you'll find cross-language examples here for different tools.

---

## 📦 Tools Covered

| Tool       | Languages Supported         | Use Cases                        |
|------------|-----------------------------|----------------------------------|
| Selenium   | Python, C#, Java             | Browser UI automation & testing |
| Playwright | Node.js, Python              | Fast, reliable UI scripting     |
| Puppeteer  | Node.js                      | Chrome/Chromium automation      |

---

## 📂 Folder Overview

### 🔹 `selenium/`
Scripts using the Selenium WebDriver. Good for automating legacy apps or supporting multiple browsers.

- `/python/`: Scripts using `selenium` and `pytest`
- `/csharp/`: Visual Studio projects using `Selenium.WebDriver`
- `/java/`: Maven or Gradle-based projects with Selenium

### 🔹 `playwright/`
Next-gen automation framework by Microsoft. Highly reliable for modern SPAs.

- `/nodejs/`: JavaScript/TypeScript projects
- `/python/`: Scripts using `playwright-pytest`

### 🔹 `puppeteer/`
Headless browser automation library for Node.js. Best for Chrome-focused automation.

- `/nodejs/`: Simple and powerful browser scripts

---

## ⚡ Example Use Cases

- Login and form submission automation
- Downloading reports from dashboards
- Scraping data from authenticated pages
- End-to-end (E2E) test flows
- UI regression testing

---

## ▶️ Getting Started

Each subfolder includes:

- `README.md` with setup instructions
- Scripts ready to run
- Dependency installation guide

For example, to run a Python Selenium script:

```bash
cd selenium/python
pip install -r requirements.txt
python login_test.py
```