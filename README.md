## Overview

This GitHub repository serves as a showcase of small projects that I have done during my journey as a student. These projects reflect my dedication to continuous learning and the knowledge gained in various topics. 

As a student, this repository provides an insight into my practical skills, problem-solving abilities and creative thinking.

## Table of Contents

1. [Introduction](#introduction)
2. [Projects](#projects)
    - [Quote Of The Day](#quote-of-the-day)
3. [Blog](#blog)


## Introduction

As a student, I am passionate about exploring new technologies, academic approaches, and innovative tools to enhance my learning experience. This repository is a curated collection of small projects and experiments that I have initiated and completed during my academic journey. These projects span a range of topics, from academic assignments to personal coding challenges, and they represent my commitment to personal and academic development.

## Projects

### Quote Of The Day
- **Description:** 
The "Quote Of The Day" project is a web application designed to motivate users by presenting them with a new quote every day. 
Users can visit the applications homepage, where they will be greeted with a welcome message. On this page, there is a button labeled "Quote of the Day." When users click this button, they are redirected to a page that displays a random quote from a list of quotes stored in a text file. Refreshing the page will display a different quote each time.
- **Objective:** 
The primary objective of this project was to gain familiarity with ViewData, a method for passing data from a controller to a view.
  - How `ViewData` Works in the Project:
    1. **Data Retrieval:** In the `QuoteController.cs`, we find the quote " from our list of quotes in the text file `Quotes.txt` .

    2. **Data Storage:** Once we have the  quote, we save it in `ViewData` by assigning the quote to the specific key withing `ViewData`.
  
        ```csharp
        //C#
          ViewData["QuoteOfTheDay"] = quoteOfTheDay;
      
        ```
    3. **View Access and Data Presentation:** In the Razor view `QuoteOfTheDay.cshtml`, we can access the stored data using the key, which retrieves the value and display it in the HTML of the view, wherever we want.
        ```csharp
        //cshtml
          @ViewData["QuoteOfTheDay"]`
      
        ```

- **Technologies Used:** 
  - ASP.NET
  - C#
  - HTML/CSS
  - Text file with quotes
- **Link:** [Project 1](#link-to-project-1)

## Blog
In the ever-changing world of information technology, a constant flow of topics has sparked my interest throughout my journey in school, classes, online communities, at the workplace, and even during events. My blog is a digital journal of my IT journey and the place where I dive into these intriguing subjects.

Below, you can find a link to my monthly blog posts on IT-related topics:
[Blogposts](https://thasmini.wordpress.com/)

---
Thank you for visiting this repository and for your interest.

**- Thasmini Thayaparan**

