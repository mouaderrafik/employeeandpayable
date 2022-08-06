<h1>The Employee and Payable Case Study</h1>

In our code, as given in Appendix A, we have created a C# console application with all required classes. In the Main method, we have created different employee/invoice objects and added them to the List of Payable types. Then we iterated through this list and calculated the sum of all values from the ***getPaymentAmount*** method return. Printed the results to the console as shown in figure 1. 

<p align="center">
<img src="https://i.imgur.com/fzYKmfg.png" height="85%" width="85%" alt="Figure 1: Console Output "/>
  
Figure 1: Console Output 
</p>
<br />


<h3>Detailed Analysis</h3>

In our code, we have followed the same guidelines as given. ***Payable*** is an interface that declares the ***getPaymentAmount*** method. ***Employee*** is an abstract class that is a subclass of Payable and has three instance variables. ***CommissionEmployee*** is a concrete class that is a subclass of Employee and adds two instance variables. ***BasePlusCommissionEmployee*** is a concrete class that is a

subclass of CommissionEmployee and adds one instance variable. ***HourlyEmployee*** is a concrete class that is a subclass of Employee and adds two instance variables. ***SalariedEmployee*** is a concrete class that is a subclass of Employee and adds one instance variable. ***Invoice*** is a concrete class that is a subclass of Payable and has four instance variables. 

<h3>The Payable Interface</h3>

An interface declares one or more methods but does not implement the methods. 

<p align="center">
<img src="https://i.imgur.com/JYFpfIu.png" height="85%" width="85%" alt="Figure 2: The Payable Interface  "/>
  
Figure 2: The Payable Interface  
</p>
<br />


<h3>The Invoice and Employee Classes</h3>

We have declared classes that implement interfaces. For example, both the ***Employee*** class and ***Invoice*** class specify "***: Payable***", which is a promise to implement the ***getPaymentAmount*** method. This allows ***Employee*** objects and ***Invoice*** objects to be processed polymorphically as ***Payable*** objects because they all implement the ***getPaymentAmount*** method. 

The ***Invoice*** is a basic class: instance variables, a constructor that initializes them, getters and setters, a ***ToString*** method, and a ***getPaymentAmount*** method. The ***ToString*** and ***getPaymentAmount*** use the get methods rather than directly accessing the variables. 

Code screenshots of the Invoice class are shown below:

<p align="center">
<img src="https://i.imgur.com/I9onnI4.png" height="85%" width="85%" alt="Figure 3: The invoice Class"/>
<img src="https://i.imgur.com/hSeNrUD.png" height="85%" width="85%" alt="Figure 3: The invoice Class"/>
<img src="https://i.imgur.com/5svCoI3.png" height="85%" width="85%" alt="Figure 3: The invoice Class"/>
<img src="https://i.imgur.com/vzT6gnK.png" height="85%" width="85%" alt="Figure 3: The invoice Class"/>
<img src="https://i.imgur.com/PKtq1k5.png" height="85%" width="85%" alt="Figure 3: The invoice Class"/>
<img src="https://i.imgur.com/zCZMQ3p.png" height="85%" width="85%" alt="Figure 3: The invoice Class"/>

Figure 3: The invoice Class 
</p>
<br />
 

The ***Employee*** class is a little more complicated. It is an abstract class because it does not implement the ***getPaymentMethod***. 

<h3>Subclasses of Employee</h3>

Each of the subclasses have the following features: 

It extends the Employee class or a subclass of ***Employee***. The parameters of its constructor include values to initialize all the instance variables of the class and its superclasses. The first line of code in the constructor calls the constructor of the immediate superclass. The ***getPaymentAmount*** method is implemented, fulfilling the promise made by the ***Employee*** class. The ***ToString*** method combines the result of the ***ToString*** method of the superclass with additional information. We have used the ***base*** keyword. The ***constructor***, ***getPaymentAmount*** and ***ToString*** methods used the ***getters*** and ***setters*** to get and set the instance variables. Code for this class and remaining requirements are given in **Employee & Payable file**.

