using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
namespace InterfaceApplication {
// INTERFACE
public interface Payable {
double getPaymentAmount();
}
public class Invoice : Payable {
// MEMBER VARIABLES
private string partNumber;
private string partDescription;
private int quantity;
private double pricePerItem;
// DEFAULT CONSTRUCTOR
public Invoice()
{
setPartNumber("");
setPartDescription("");
setQuantity(0);
setPricePerItem(0.0);
}
// PARAMETERIZED CONSTRUCTOR
public Invoice(string pPartNumber, string pPartDescription, int pQuantity, double pPricePerItem)
{
setPartNumber(pPartNumber);
setPartDescription(pPartDescription);
setQuantity(pQuantity);
setPricePerItem(pPricePerItem);
}
// SETTER FUNCTIONS
public void setPartNumber(string pPartNumber)
{
partNumber = pPartNumber;
}

public void setPartDescription(string pPartDescription)
{
partDescription = pPartDescription;
}
public void setQuantity(int pQuantity)
{
quantity = pQuantity;
}
public void setPricePerItem(double pPricePerItem)
{
pricePerItem = pPricePerItem;
}
// GETTER FUNCTIONS
public string getPartNumber()
{
return partNumber;
}
public string getPartDescription()
{
return partDescription;
}
public int getQuantity()
{
return quantity;
}
public double getPricePerItem()
{
return pricePerItem;
}
public double getPaymentAmount() {
return getQuantity() * getPricePerItem();
}
public void to_String()
{
Console.WriteLine("------------ INVOICE DETAIL ------------");
Console.WriteLine("INVOICE PartNumber : {0}", getPartNumber());
Console.WriteLine("INVOICE PartDescription : {0}", getPartDescription());
Console.WriteLine("INVOICE Quantity : {0}", getQuantity());
Console.WriteLine("INVOICE PricePerItem : {0}", getPricePerItem());

Console.WriteLine();
}
}
public abstract class Employee : Payable
{
// MEMBER VARIABLES
private string firstName;
private string lastName;
private string socialSecurityNumber;
public Employee()
{
setFirstName("");
setLastName("");
setSocialSecurityNumber("");
}
public Employee(string pFirstName, string pLastName, string pSocialSecurityNumber)
{
setFirstName(pFirstName);
setLastName(pLastName);
setSocialSecurityNumber(pSocialSecurityNumber);
}
// SETTER FUNCTIONS
public void setFirstName(string pFirstName)
{
firstName = pFirstName;
}
public void setLastName(string pLastName)
{
lastName = pLastName;
}
public void setSocialSecurityNumber(string pSocialSecurityNumber)
{
socialSecurityNumber = pSocialSecurityNumber;
}
// GETTER FUNCTIONS
public string getFirstName()
{
return firstName;
}
public string getLastName()

{
return lastName;
}
public string getSocialSecurityNumber()
{
return socialSecurityNumber;
}
public void to_String()
{
Console.WriteLine("EMPLOYER FirstName : {0}", getFirstName());
Console.WriteLine("EMPLOYER LastName : {0}", getLastName());
Console.WriteLine("EMPLOYER SocialSecurityNumber : {0}", getSocialSecurityNumber());
}
public abstract double getPaymentAmount();
}
public class SalariedEmployee : Employee
{
// MEMBER VARIABLES
private double weeklySalary;
public SalariedEmployee()
{
weeklySalary = 0.0;
}
public SalariedEmployee(string pFirstName, string pLastName, string pSocialSecurityNumber, double
pWeeklySalary)
: base (pFirstName, pLastName, pSocialSecurityNumber)
{
weeklySalary = pWeeklySalary;
}
// SETTER FUNCTIONS
public void setWeeklySalary(double pWeeklySalary)
{
weeklySalary = pWeeklySalary;
}
// GETTER FUNCTIONS
public double getWeeklySalary()
{
return weeklySalary;
}

public void to_String()
{
Console.WriteLine("------------ SALARIED EMPLOYEE DETAIL ------------");
base.to_String();
Console.WriteLine("SALARIED EMPLOYEE WeeklySalary : {0}", getWeeklySalary());
Console.WriteLine();
}
public override double getPaymentAmount() {
return getWeeklySalary();
}
}
public class HourlyEmployee : Employee
{
// MEMBER VARIABLES
private double wage;
private double hours;
public HourlyEmployee()
{
wage = 0.0;
hours = 0.0;
}
public HourlyEmployee(string pFirstName, string pLastName, string pSocialSecurityNumber, double
pWage, double pHours)
: base (pFirstName, pLastName, pSocialSecurityNumber)
{
wage = pWage;
hours = pHours;
}
// SETTER FUNCTIONS
public void setWage(double pWage)
{
wage = pWage;
}
public void setHour(double pHours)
{
hours = pHours;
}
// GETTER FUNCTIONS
public double getWage()
{
return wage;

}
public double getHours()
{
return hours;
}
public void to_String()
{
Console.WriteLine("------------ HOURLY EMPLOYEE DETAIL ------------");
base.to_String();
Console.WriteLine("HOURLY EMPLOYEE Wage : {0}", getWage());
Console.WriteLine("HOURLY EMPLOYEE Hours : {0}", getHours());
Console.WriteLine();
}
public override double getPaymentAmount() {
return getWage() * getHours();
}
}
public class CommissionEmployee : Employee
{
// MEMBER VARIABLES
private double grossSales;
private double commissionRate_inPercent;
public CommissionEmployee()
{
grossSales = 0.0;
commissionRate_inPercent = 0.0;
}
public CommissionEmployee(string pFirstName, string pLastName, string pSocialSecurityNumber,
double pGrossSales, double pCommissionRate_inPercent)
: base (pFirstName, pLastName, pSocialSecurityNumber)
{
grossSales = pGrossSales;
commissionRate_inPercent = pCommissionRate_inPercent;
}
// SETTER FUNCTIONS
public void setGrossSales(double pGrossSales)
{
grossSales = pGrossSales;
}
public void setCommissionRate(double pCommissionRate_inPercent)

{
commissionRate_inPercent = pCommissionRate_inPercent;
}
// GETTER FUNCTIONS
public double getGrossSales()
{
return grossSales;
}
public double getCommissionRate_inPercent()
{
return commissionRate_inPercent;
}
public void to_String()
{
Console.WriteLine("------------ COMMISSION EMPLOYEE DETAIL ------------");
base.to_String();
Console.WriteLine("COMMISSION EMPLOYEE GrossSales : {0}", getGrossSales());
Console.WriteLine("COMMISSION EMPLOYEE CommissionRate_% : {0}",
getCommissionRate_inPercent());
Console.WriteLine();
}
public override double getPaymentAmount() {
return getGrossSales() * getCommissionRate_inPercent() / 100;
}
}
public class BasePlusCommissionEmployee : CommissionEmployee
{
// MEMBER VARIABLES
private double baseSalary;
public BasePlusCommissionEmployee()
{
baseSalary = 0.0;
}
public BasePlusCommissionEmployee(string pFirstName, string pLastName, string
pSocialSecurityNumber, double pGrossSales, double pCommissionRate_inPercent, double pBaseSalary)
: base (pFirstName, pLastName, pSocialSecurityNumber, pGrossSales, pCommissionRate_inPercent)
{
baseSalary = pBaseSalary;
}
// SETTER FUNCTIONS

public void setBaseSalary(double pBaseSalary)
{
baseSalary = pBaseSalary;
}
// GETTER FUNCTIONS
public double getBaseSalary()
{
return baseSalary;
}
public void to_String()
{
Console.WriteLine("------------ BASE SALARY COMMISSION EMPLOYEE DETAIL ------------");
base.to_String();
Console.WriteLine("BASE SALARY COMMISSION EMPLOYEE BaseSalary : {0}", getBaseSalary());
Console.WriteLine();
}
public override double getPaymentAmount() {
//double temp = base.getPaymentAmount();
return base.getPaymentAmount() + getBaseSalary();
}
}
class Project {
static void Main() {
// OBJECTS INSTANTIATED USING CONSTRUCTORS
HourlyEmployee hourlyEmployee_1 = new HourlyEmployee("Jon", "Dow", "123123123", 100, 4);
SalariedEmployee salariedEmployee_1 = new SalariedEmployee("John", "Hanry", "231242423",
450);
Invoice invoice_1 = new Invoice("Initial", "This is description of the Invoice.", 4, 4.5);
CommissionEmployee commissionEmployee_1 = new CommissionEmployee("Sarah", "Hamber",
"756854634", 10000, 30);
BasePlusCommissionEmployee basePlusCommissionEmployee_1 = new
BasePlusCommissionEmployee("Rumi", "Ruman", "854563453", 10000, 20, 5000);
/*hourlyEmployee_1.to_String();
salariedEmployee_1.to_String();
invoice_1.to_String();
commissionEmployee_1.to_String();
basePlusCommissionEmployee_1.to_String();*/
// ADD OBJECTS TO THE LIST OF PAYEABLES TYPE
List<Payable> listOfPayables = new List<Payable>();
listOfPayables.Add(hourlyEmployee_1);
listOfPayables.Add(salariedEmployee_1);

listOfPayables.Add(invoice_1);
listOfPayables.Add(commissionEmployee_1);
listOfPayables.Add(basePlusCommissionEmployee_1);
double totalPayable = 0;
foreach (Payable tempPayable in listOfPayables)
{
totalPayable += tempPayable.getPaymentAmount();
}
Console.WriteLine("Total Payable Amount is : {0}" , totalPayable);
}
}
}