# 🚀 90-Day C# & .NET Journey

> From console apps to production-ready applications in 90 days

**Start Date:** February 8, 2026  
**Goal:** Ship a real SaaS product (FitTrack Pro) and land a .NET developer role  
**Current Progress:** Week 1 - Foundation Building

---

## 📊 Progress Tracker

- [x] **Week 1:** C# Fundamentals & Console Applications (Days 1-7)
- [ ] **Week 2:** First Web Application with ASP.NET Core (Days 8-14)
- [ ] **Week 3-4:** Databases & Entity Framework Core (Days 15-30)
- [ ] **Week 5-8:** Build Real Product - FitTrack Pro MVP (Days 31-60)
- [ ] **Week 9-10:** Deploy & Launch Preparation (Days 61-70)
- [ ] **Week 11-12:** First Users & First Revenue (Days 71-90)

---

## 🎯 Projects Built

### Week 1: Foundation Building
---
#### Day 0: Calculator App ✅
**What I Built:**  
A fully functional calculator with continuous operation support and input validation.

**What I Learned:**
- Variables, data types, and type conversion (`Convert.ToInt32`, casting to `decimal`)
- Conditional logic with `if/else` statements
- While loops for program flow control
- String interpolation for clean output (`$"Result: {x}"`)
- Error handling for edge cases (division by zero, invalid operators)

**Key Features:**
- ➕ ➖ ✖️ ➗ All basic operations
- 🔄 Continuous calculation mode
- ✅ Input validation
- 🚫 Division by zero protection

**Code:** [Day0-Calculator](./week1-foundations/day0-Calculator/program.cs)

---

#### Day 1: Number Guessing Game ✅
**What I Built:**  
An interactive guessing game with attempt tracking and smart input validation.

**What I Learned:**
- Random number generation with `Random` class
- `do-while` loops for game logic
- Writing reusable functions with parameters and return values
- `int.TryParse()` for safe input parsing
- Boolean flags for control flow
- Null-coalescing operator (`??`) for safe string handling
- Code organization and the DRY (Don't Repeat Yourself) principle

**Key Features:**
- 🎲 Random number generation (1-10)
- 🎯 Limited attempts with feedback system
- ✅ Robust input validation function
- 🔄 Play again functionality
- 📊 Attempt counter and win/loss tracking

---

#### Day 2: Todo List App ✅
**What I Built:**  
Full CRUD todo application with completion tracking

**What I Learned:**
- Working with `List<T>` collections
- Parallel data structures (maintaining sync between two Lists)
- CRUD operations (Create, Read, Update, Delete)
- Debugging data structure relationships
- Switch statements for menu handling

**Key Achievement:**
Discovered and solved index mismatch bug by switching from array to parallel Lists

**Code:** [Day2-TodoList](./week1-foundations/day2-TodoList/program.cs)

---
**Technical Highlights:**
```csharp
// Reusable validation function
int GetValidatedIntegerInput(string prompt, int min, int max)
{
    // Ensures input is valid integer within range
    // Handles non-numeric input and out-of-range values
}
```

**Code:** [Day1-GuessingGame](./week1-foundations/day1-GuessingGame/Program.cs/)

---

## 💡 Core Concepts Mastered

### Week 1
- ✅ C# Syntax & Fundamentals
  - Variables, data types, type conversion
  - Operators (arithmetic, comparison, logical)
  - String manipulation and interpolation
  
- ✅ Control Flow
  - `if/else` conditional statements
  - `while` and `do-while` loops
  - Boolean logic and flags
  
- ✅ Functions & Methods
  - Creating reusable functions
  - Parameters and return values
  - Function documentation with comments
  
- ✅ Best Practices
  - Input validation and error handling
  - DRY principle (Don't Repeat Yourself)
  - Clean, readable code structure
  - Meaningful variable names

---

## 🛠️ Tech Stack (So Far)

- **Language:** C# 
- **Framework:** .NET 10.0
- **IDE:** Visual Studio Code
- **Version Control:** Git & GitHub

---

## 📈 What's Next

### Upcoming Projects (Week 1)
- [ ] **Day 2-3:** Todo List Console App
  - Learn: Collections (Lists), CRUD operations
  
- [ ] **Day 4-5:** Todo List with Classes (OOP)
  - Learn: Object-oriented programming, classes, objects, properties

### Week 2 Preview
- First web application with ASP.NET Core
- Understanding MVC pattern
- Building pages that run in a browser

---

## 🎓 Learning Principles I'm Following

1. **Build > Study** - Learning by doing, not just watching tutorials
2. **Ship Ugly v1s** - Done is better than perfect
3. **Just-in-Time Learning** - Learn what I need when I need it
4. **Google Is My Co-Pilot** - Real devs search for solutions constantly
5. **Iterate Fast** - Build, get feedback, improve, repeat

---

## 🎯 End Goal: FitTrack Pro

**The Product:** A fitness tracking SaaS for bodybuilders and athletes

**Tech Stack (Planned):**
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server / PostgreSQL
- React or Blazor (Frontend)
- Azure / Railway (Deployment)

**Timeline:** Ship by Day 90

---

## 📫 Connect With Me

- **GitHub:** [alidev313xdot](https://github.com/alidev313xdot)
- **LinkedIn:** https://www.linkedin.com/in/farmanali-dsa/
- **Location:** Pakistan 🇵🇰

---

## 📝 Notes

This repository documents my journey from beginner to building production-ready .NET applications. Every project, no matter how small, represents real learning and problem-solving.

**Why I'm doing this publicly:**
- Accountability through transparency
- Building in public to help others on the same journey
- Creating a portfolio that shows growth, not just final results

---

**"The best time to start was yesterday. The second best time is now."**

Last Updated: February 8, 2026
