# Hudl

All tests in feature file :
https://github.com/nehasabikhi/Hudl/blob/main/TestProject/Features/Login.feature

****1)	Tech used: ****

i)	C# -- Language 

ii)	Selenium – Web driver to interact with Browser.

iii)	NUnit – To run tests 

iv)	Spec flow – To write features in Grekin language.


****2)	Structure:****
1)	Features – Contains all the feature files in Grekin language.
2)	Steps – Contains step definition Which join all the given when then in the feature files.
3)	Pages – Every Page have their own behaviour E.g.: Landing page where user first land on Login page where user Login.
![image](https://user-images.githubusercontent.com/13966346/166172123-8c9f0fbe-05ce-4f1f-bd64-f81b2f4fc9bc.png)

5)	Actions Contains all the actions like wait, click etc.
6)	Utilities contains more complex code.
7)	Helpers contains extensions or helper class. E.g.: Screenshots, Get configuration Etc

![image](https://user-images.githubusercontent.com/13966346/166172166-04c58ad4-4623-409f-8aa1-d65580ab736f.png)

9)	Base Folder contains all the base pages like base steps, base page or hooks.

 ![image](https://user-images.githubusercontent.com/13966346/166172195-8b2e847b-03d0-42f2-a3da-84d7d33c4a36.png)

10)	Driver contains all the driver functions.
11)	Settings contains setting files like configurations. Which will help to configure browser and url .

For screenshot class I used extenstions 
Setting file is used to configure broser and url (As I donot want to hardcode them)

 
All the tests are running and passing 
![image](https://user-images.githubusercontent.com/13966346/166170579-8e86aff9-24f1-4647-8151-a7fc2b144934.png)

Build and run instruction to run on local machine: 
Steps:
Download Visual studio community 
Open TestProject.sln file 
Build using Ctrl + b command or from Visual studio UI 
 ![image](https://user-images.githubusercontent.com/13966346/166171138-47babb53-9662-4873-a653-e57a2deb8ffe.png)

Run tests using test explorer:

![image](https://user-images.githubusercontent.com/13966346/166171146-6a27540c-7244-4769-b80c-b75d87e14cfb.png)


Note : To run specflow you need to enable specflow extention in visual studio extenstions 
Click extensions , Manage extensions 



![image](https://user-images.githubusercontent.com/13966346/166171676-1e9238e8-3140-4340-8e52-60a8c71d50a0.png)
search for specflow and download specflow 


![image](https://user-images.githubusercontent.com/13966346/166171650-c7dfea1f-918e-46e3-897a-df8a5cfa208b.png)



Created test report using specflow live docs : 
https://docs.specflow.org/projects/getting-started/en/latest/GettingStarted/Step9.html
![image](https://user-images.githubusercontent.com/13966346/166171503-89d4b144-c9ed-484c-81da-4351097f776f.png)

 


