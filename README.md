# HawkSoft Coding Assessment

To whom it may concern;

Thank you for your time. In here you will find my attempt at this coding challenge you have given me. Please note that it has been a long time since I've done full stack development - so a lot of this was new to me. That is also why I was unable to complete very much. So far I was able to stand up a very basic and rudementary REST service. I also started laying out the boilerplate code for an Angular front end. 

**The REST service can compile and run. It does things - but does not meet the requirements.**

**The Angular App does not run and therefore cannot be demonstrated.**

With respect to the .NET Rest Service (HawkSoftContacts)
* There is a *User* and a *Contact* model. 
  * I have not set up the service/database to properly track the foreign key relationship. When I ran [postman](https://www.postman.com/) to add a contact and passed in the value for *UserRefId* the *User* field was null. If I were to continue development on this I'd probably remove the *User* property from the *Contact* model - but I suspect I'm doing something wrong by not using Entity Framework properly.
  * The *User* password is stored as plain text - there is no such thing as security in this implementation  
* There is no paging impelmented
* Again - security does not exist. Anyone can edit/view/delete anyones contacts at this point. 
* Nothing has been done to account for load such as paging, limiting data retrieved, limiting number of calls, etc
* This project is mostly boilerplate code with some basic model implementation.

With respect to the Angular App (ClientApp)
* This is even more incomplete as I haven't even finished with the boilerplate code yet.
* It is very incomplete.
* The last time I worked on all parts of a full stack application was before Angular 2.0 and we used jQuery & jQuery Mobile.
