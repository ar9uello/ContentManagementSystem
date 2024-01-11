# Content Management System (CMS)

## I have been asked to develop the following feature:

This feature will enable the display of any HTML content as a new page on the website, functioning like a simplified version of WordPress or a similar content management system (CMS).

---

### Required:
The new feature includes the following API capabilities:
- Create a new HTML content page using the 'InsertOrUpdateCMSContent' API method.
- Retrieve the content with the 'GetCMSContent' API method.
- Use the 'GetAll' WebAPI method to retrieve all entered content entries.

### Implemented:
At the outset of the requirements, Entity Framework was mentioned. So, I implemented the backend (BE) using Entity Framework connected to SqlServer. I created the domain, developed an unpublished AppService, and configured the endpoints exactly as requested:
![image](https://github.com/ar9uello/ContentManagementSystem/assets/55641229/c2cb8e75-69eb-4939-9691-d0b16fc8e182)

---

### Required:
Validate the maximum content length to ensure it does not exceed the DB datatype limit and prevent exceptions.

### Implemented:
I have validated the content length both on the Backend using DataAnnotations and on Frontend using angular form control validators, see:
![image](https://github.com/ar9uello/ContentManagementSystem/assets/55641229/60e46b99-fabb-4e4e-af37-0ca016541036)

---

### Required:
Unit Testing: Enhance the existing unit test project with new tests to cover these API methods.

### Implemented:
Due to lack of time, what I did was only validate the AppService, which is the core used by endpoints.
For more details of the unit tests implemented see: [Unit Tests](https://github.com/ar9uello/ContentManagementSystem/blob/main/aspnet-core/test/ContentManagementSystem.Application.Tests/Samples/SampleAppServiceTests.cs)
![image](https://github.com/ar9uello/ContentManagementSystem/assets/55641229/dce48a8c-4cb1-483d-80cc-a41a065d9475)


---

### Required:
Use ABP Plug-in infrastructure in order to decouple the feature code from the framework code base.

### Implemented:
Due to lack of time, I only created the PlugIn sample project and added it to the HttpApi.Host project, see:
![image](https://github.com/ar9uello/ContentManagementSystem/assets/55641229/ac7536df-d640-45eb-b26d-699424262dc3)

---

### Required:
This feature will also offer a user-friendly, responsive HTML interface enabling users to:
- Display each content entry (page) as a new item in the main navigation. Clicking on the menu item will display the corresponding content.
- Create new pages and edit existing ones. Consider using free WYSIWYG editing controls for an optimal user experience.

### Implemented:
In the Frontend (FE) part, as angular was also mentioned, I did the project with angular.

- Display each content entry (page) as a new item in the main navigation:
![image](https://github.com/ar9uello/ContentManagementSystem/assets/55641229/3ba69f8b-273f-4b7f-8965-24a36598bc5f)

- Create new pages. Consider using free WYSIWYG editing controls for an optimal user experience.
  - First, you need to log in to be able to create and edit content:
![image](https://github.com/ar9uello/ContentManagementSystem/assets/55641229/e12ad0ef-7d98-4370-a8e1-5769f98547eb)

  - Edit existing ones
![image](https://github.com/ar9uello/ContentManagementSystem/assets/55641229/f7d2d0c8-e259-4af3-afa1-a2d80c17283c)

---

### Required:
When you are satisfied with your work record a short demo video of your CMS feature which will show Web API and new content pages in UI.

### Implemented:
https://github.com/ar9uello/ContentManagementSystem/assets/55641229/8bca7e4a-dc0d-4d3d-9816-896df073199d

---

### Required:
Upload your source code to https://github.com/ and share the public repo with us for code review.

### Implemented:
This is the URL of the GitHub repository: [GitHub](https://github.com/ar9uello/ContentManagementSystem)

---

## Final words
### This has been my ABP Developer Technical Assignment. I have enjoyed and learned a lot. Thank you so much. And I hope to hear from you soon.


Regards

Robert



