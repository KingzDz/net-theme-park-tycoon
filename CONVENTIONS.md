# Conventions

Besides following the code conventions below please keep paying attention what other developers do. If you want to place a file in a directory with these files:

- conventions-document.docx
- moscow-information-table.txt
- relevant-details-for-john.png

<u>You then of course name your file similarly:</u>

* in-the-same-manner.png

And <u>not</u>:

Completely_different_than_the_other_files1.jpeg



## Code Conventions

**Code is always written in English**. **Comments should also be written in English**, or if it helps to also have a Dutch version: have two comments in different languages. 



### Objects, Controls, Forms and Windows

**Classes are always UpperCamelCase and Nouns**.

```c#
class Worker 
{ 
    
}
```



**Public properties are written shorthand**.

```c#
public DataType PropertyName;
```

The shorthand `{ get; set; }` structure is only used to make something un-settable from outside the class:

```C#
public decimal Balance { get; private set; }
```



**Objects, Controls, Windows and Forms are always written in UpperCamelCase**. The name is always a noun (a thing). Forms always end in 'Form'. Windows always end in Window.

```c#
public partial class ProfileForm : Form
```

```c#
public partial class MainForm : Form
```

```c#
public partial class MainWindow : Window
```

Private variables in a class (better known as: fields) are always lowerCamelCase.

```c#
private string fieldName;
```



**Controls are always written lowerCamelCase** and the name ends with the type of the Control (e.g.: TextBox, Label, Button, ListBox, PictureBox, ComboBox). This way Intellisense (auto-complete in Visual Studio) can help us find controls faster.

```c#
private Button replyButton;
private ListBox contactsListBox;
private ComboBox roleComboBox;
```



### Methods

**All methods must be UpperCamelCase and verbs**. Can you not think of a method name that is a verb? Then have it start with a verb (e.g: MakeChanges and DoConfiguration). There can be no underscores(_) in a method-name **unless** the method is an event handler.

```c#
private void Refresh()
```



**Event handlers also follow the UpperCamelCase naming rules** (because they are methods as well). Event handlers contain an underscore(_) between the UpperCamelCase name of the Control and the event name:

```c#
private void ReplyButton_Click(object sender, ClickEventArgs e)
```



**Local variables** and **parameters** are always lowerCamelCase (no underscores)

```c#
// withLastName is a parameter and is lowerCamelCase
private string GetCoderName(bool withLastName)
{
    string lastName = "Lutt"; // this variable is local to the GetCoderName method
    
    if(withLastName)
    {
        return "Timothy " + lastName;
    }
    else
    {
        return "Timothy";
    }
}
```

