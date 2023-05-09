using System;

namespace CustomerProductClasses
{
public class Customer
{
private int id;
private string firstName;
private string lastName;
private string email;
private string phoneNumber;

    public Customer() { }

    public Customer(int customerId, string fName, string lName, string emailAddr, string phoneNum)
    {
        id = customerId;
        firstName = fName;
        lastName = lName;
        email = emailAddr;
        phoneNumber = phoneNum;
    }

    public int Id
    {
        get
        {
            return id;
        }
        set
        {
            id = value;
        }
    }

    public string FirstName
    {
        get
        {
            return firstName;
        }
        set
        {
            firstName = value;
        }
    }

    public string LastName
    {
        get
        {
            return lastName;
        }
        set
        {
            lastName = value;
        }
    }

    public string Email
    {
        get
        {
            return email;
        }
        set
        {
            email = value;
        }
    }

    public string PhoneNumber
    {
        get
        {
            return phoneNumber;
        }
        set
        {
            phoneNumber = value;
        }
    }

    public override string ToString()
    {
        return String.Format("Id: {0} First Name: {1} Last Name: {2} Email: {3} Phone Number: {4}", id, firstName, lastName, email, phoneNumber);
    }
}

}