# Lab 9: EduLibrary - University Library Management System

## Overview
A comprehensive university library management system demonstrating advanced OOP concepts including inheritance, interfaces, and abstract classes.

## Functionality
- Management of different types of library materials (books, textbooks, reference books)
- Lending and returning materials
- Search by author, title, and ID
- Library statistics
- Availability status tracking

## Class Structure
- `ILendable` - interface for lendable materials
- `LibraryItem` - abstract base class
- `Book` - class for fiction literature
- `Textbook` - class for textbooks
- `Reference` - class for reference literature
- `UniversityLibrary` - main library class

## Key Features
- **Polymorphism**: Different material types with shared interface
- **Inheritance**: Textbook and Reference inherit from Book
- **Encapsulation**: Protected properties with public accessors
- **Collection Management**: LINQ queries for filtering and grouping
