### Part 1
[Page1](Training/Page1.md)

#### Q1: What does it mean to create an "instance" of an object?
To create an "instance" for an object means to initialize its state by its class.
#### Q2: What does it mean when we say "Create a local variable"?
It means to declare the variable but only within the chunk of code it was initialized in.
#### Q3: The static keyword is a modifier, what does this modifier do to the members (fields, constructor, properties, and methods) of a class?
A static keyword allows access to all instances. Such as if that is from fields, a class, etc! :smile:
#### Q4: Do you need an instance of an object to call a static method?
No, you dont because a static method belongs to the class.
#### Q5: Can you create an instance of a static class?
No, you cannot because static classes is deemed "sealed" therefore, cannot inherit.
#### Q6: Can you manually call a static constructor? When is it called?
No, because it is called automatically before the first instance of the class creation. 
#### Q7: Did you have to create an instance of MyDatabase to access Data? Why?
Yes! because data is not a static member of the MyDatabase class. :smiley:
#### Q8: When you ran your code the line "This list is loading" appeared. Where did that come from and why did it appear when it did?
I believe it may have just been a conditional statement /part of the program. If not, I believe you may have added it into your code as a loading precaution.
### Part 2
[Page2](Training/Page2.md)

#### Q9: What is encapsulation?
Encapsulation is a bundle/chunk of data that is operated into a single unit, such as a class.
#### Q10: What are the other two, or 3 depending on the source, pillars of object-oriented programming?
 The 2 other pillars of object oriented programming are inheritance and polymorphism. :smiley_cat:
#### Q11: After our refactor of Product, it only has fields that are _blank_ among all the Objects in the database.
After a refactor, we are left with fields that are common in all object databases.
#### Q12: We made our DisplayProductInfo() method `virtual`. What does virtual do?
'virtual' allows for a methods to be overridden in classes.
#### Q13: Why do you think we made that method virtual ( only wrong answer is a blank answer. Give it a shot. )?
Because it is for inhertiance classes? :smirk_cat:
#### Q14: What does dervied mean in the context of inheritance?
Dervied means it is a sub branch from the main. Such as if we inherit a sub class from another class to pass on some of the data. :scream_cat: 
#### Q15: Is one class is derived, the class that it derives from is considered the "b___" class. What is it?
It is known as the base class. 
#### Q16: When inheriting from a parent class, which class member ( field, constructor, properties, or method ) do you HAVE to create in your child class?
You connect them together with the constructor at the end putting " : base ()" and then the existing information for the other class.
#### Q17: Our constructor has the syntax `public Groceries(string name, double price, string expiryDate) : base(name, price)`. What is this for?
The syntax is used for calling the base constructor with specific parameters.
#### Q18: For our DisplayProductInfo() we now used the word `override` instead of `virtual`. Why is that? And what happens if we take the word `virtual` away from the method inside of Product?
We now call it override instead because it shows that we are using implementations of a method inherited from the base class. And if we take 'virtual' away from the method such as taking away 'override' the method will not function causing an error!
#### Q19: Because we inherited from Parent, what class members did we get access to in Groceries?
Because we inherit from Parent, groceries allows us access to accessible class members of Parent.
#### Q20: What access modifier is needed for everything in your project to have access to class members ( there are 2 that would work )?
One of the modifiers is making the class 'public' while the other is making the class 'internal'.
#### Q21: When each instanced object called `DisplayProductInfo()` the output was different based on the object. Why is that?
It produces a different output because the method may become overridden in inherited classes.

## Part 3
[Page3](Training/Page3.md)

#### Q22: What does the abstract keyword do exactly? What does it prevent?
The abstract keyword allows you to create classes as well as it allows you to prevent the inheritance of a class.
#### Q23: The abstract method no longer has a body, why is that? We also removed the word virtual, how do virtual and abstract relate?
The abstract method no longer has a body because it is meant to be overridden by subclasses. The word "virtual" and abstract relate in the sense that subclasses must provide an implementation.
#### Q24: We turned our constructor's accessible type to `protected`. What objects have access to the constructor now that it's `protected`. And since we turned our class `abstract` why doesn't it matter that we can't create a new instance of `Product` in main?
The objects that still have access to the constructor even if it is 'protected' are its class and its sub classes. And since the class is now 'abstract' it matters because abstract classes are implemented for the purpose of inheritance and not to be instantiated directly.
#### Q25: The other classes didn't need to be changed. Specifically, the DisplayProductInfo() didn't need any changing when we swapped our method from virtual to abstract. Why?
The other classes did not need to be changed because they were still able to inherit the abstract method 'DisplayProductInfo' from the base class.

## Part 4
[Page4](Training/Page4.md)

#### Q26: We set our set to private. What does private mean? And why might we want to set our set to private for our connection string (take a guess)?
I believe we turn on private for the purpose of only that class being able to change its values and properties.
## Part 5
[Page5](Training/Page5.md)

#### Q27: What method is used to get the TYPE of an instance of an object?
The method used to get the type of an instance of an object I believe is 'GetType()'?
#### Q28: What method can we use to check if one type is another?
The method we can use to check if one type is another I believe is 'equals()'.

## Part 6 (Extra credit questions)
[Page 6](Training/Page6.md)

#### Q22: What were we able to store our child classes in a list of Product?
We were able to store our child classes in a list of Products thanks to Polymorphism! :smile:
#### Q23: We were able to call DisplayProductInfo() on every object, even though each object was directly a Product. Why is that?
This is due to methods being called?
#### Q24: If I tried to access the Expiry Date field of a product, what would happen? Why would it happen?
I believe, you would get an error because the Expiry date field might not be defined.