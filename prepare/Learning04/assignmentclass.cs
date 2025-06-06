using System;
//Im trying to understand each step a little better as I write everything so ignore the little notes lol


//-------------------------Assignment Class(the base class)-----------------------------
public class Assignment
{
    //displays the new fields for this class
    public string _Studentname;
    public string _Topic;

    //----------------------------------------Sets the fields for assignment class-------------------------------
    public Assignment(String Studentname, String Topic)
    {
        //establishes the field with the "official names" and shows that the assignment class calls upon a students name and a topic.
        // this way the other classes (like math or writing) can use it bc its the base class 
        _Studentname = Studentname;
        _Topic = Topic;
    }

    //------------------------------------------GET STATEMENTS FOR ASSIGNMENT CLASS----------------------------------------------------------------
    //this grabs the student name from the student class that will be created later
    // cannot grab _studentname until its established  ex: public string _Studentname = "bob";
    // each get statement ends with ()

    public string GetStudentName()
    {
        return _Studentname;
    }
    public string GetTopic()
    {
        return _Topic;
    }
    // the "directions" are pulling from the GetStudentName and GetTopic getters to display the students name and topic
    // ex "Bob Ross here is your topic WW2"
    public string Directions()
    {
        return _Studentname + "here is your topic:" + _Topic;
    }
}