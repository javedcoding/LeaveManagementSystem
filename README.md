# Leave Management System Skeleton

This Readme is created using Awsome README Template [![Awesome](https://cdn.jsdelivr.net/gh/sindresorhus/awesome@d7305f38d29fed78fa85652e3a63e154dd8e8829/media/badge.svg)]


The Project is built on dotNet8 Entity Framework Core [![latest version](https://img.shields.io/nuget/v/Microsoft.EntityFrameworkCore)](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore) [![preview version](https://img.shields.io/nuget/vpre/Microsoft.EntityFrameworkCore)](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/absoluteLatest) [![downloads](https://img.shields.io/nuget/dt/Microsoft.EntityFrameworkCore)](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore)

This project was built for a Client and this is the Skeleton code of the project. Later on Client home page and database connection strings were added and it is not shared because of non disclosure agreement of sensitive data.



![Home](https://github.com/user-attachments/assets/5f590a1b-ce18-4f07-836d-469dfaad7319)


## How to Register

![Register](https://github.com/user-attachments/assets/deb442cb-a200-4a39-af34-1be3c8466668)


See Below pictures as References to understand Registration process. Any mandatory field which is not provided will raise and error and halt the registration process. Password length must be 12 characters atleast containing numerical and capital letter.

![Registration](https://github.com/user-attachments/assets/0afa1804-737b-4cd4-a115-2f9186d2a89d)

After a successful fields recognition which are not present in the current database a confirmation mail will be given in the given email template. Here it was tested with Papercut SMTP free version.

![RegistryConfirm Mail](https://github.com/user-attachments/assets/fc5cd721-1d55-4808-aeeb-b635891d48d3)


## Control of Admin

An Admin can view all employees and leave allocations. 

![Capture](https://github.com/user-attachments/assets/37eac9ef-3c75-4c1c-b351-1ef8a869a13b)


Admin can also review allocations and create new types of leave. After every leave requests admin can accept or decline reviewing manually.

![Admin Control View](https://github.com/user-attachments/assets/dd4844de-76bc-4b22-a203-7d93425a0990)


## Log In or Sign In

A Supervisor, Admin or an Employee can login either with their email address of the company or by their user name.

![Login](https://github.com/user-attachments/assets/2bd3b9e7-a1aa-48f7-bf63-745123be96a1)

## Requesting for leave

An Employee can request for leave using below page

![LeaveRequestView](https://github.com/user-attachments/assets/33b121e1-9a38-4cc1-b5c6-947fb8e9a307)

Employee can also review leave requests with pending, accepted, declined or canceled status flag. 

![leave request status](https://github.com/user-attachments/assets/2708234f-9308-45de-a0b3-380afbfc2d2d)


## Conclusion
This is the skeleton project. Css and html of spike were not adjusted. Later on with the client's view properties and web pages integration, CSS and logos were adjusted accordingly. I have the permission from client to share my skeleton project.
