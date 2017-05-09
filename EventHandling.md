## Event Handling
#### Java :
Changing the state of an object is known as an event. For example, click on button, dragging mouse etc. The java.awt.event package provides many event classes and Listener interfaces for event handling.

##### Java Event classes and Listener interfaces
|Event Classes|	Listener Interfaces|
|-------------|:------------------:|
|ActionEvent	|ActionListener|
|MouseEvent	|MouseListener and MouseMotionListener|
|MouseWheelEvent	|MouseWheelListener|
|KeyEvent	|KeyListener|
|ItemEvent	|ItemListener|
|TextEvent	|TextListener|
|AdjustmentEvent|	AdjustmentListener|
|WindowEvent|	WindowListener|
|ComponentEvent	|ComponentListener|
|ContainerEvent|	ContainerListener|
|FocusEvent|	FocusListener|

Java uses **Delegation event model** to handle events. There are  Events, Event Sources and Event Listeners.
The main two steps to implement delegation event model are:
* Implement the appropriate interface in the listener so that it will receive the type
of event desired.
* Implement code to register and unregister (if necessary) the listener as a recipient
for the event notifications

Java Event handling by implementing ActionListener
```
import java.awt.*;  
import java.awt.event.*;  
class AEvent extends Frame implements ActionListener{  
TextField tf;  
AEvent(){  

//create components  
tf=new TextField();  
tf.setBounds(60,50,170,20);  
Button b=new Button("click me");  
b.setBounds(100,120,80,30);  

//register listener  
b.addActionListener(this);//passing current instance  

//add components and set size, layout and visibility  
add(b);add(tf);  
setSize(300,300);  
setLayout(null);  
setVisible(true);  
}  
public void actionPerformed(ActionEvent e){  
tf.setText("Welcome");  
}  
public static void main(String args[]){  
new AEvent();  
}  
}
```
there are various places where event handling code can be put
1. Within the class.
2. Other class.
3. Anonymous class.

#### C# :
Events in the .NET Framework are based on the delegate model. The delegate model follows the observer design pattern, which enables a subscriber to register with, and receive notifications from, a provider. An event sender pushes a notification that an event has happened, and an event receiver receives that notification and defines a response to it.

An event is a message sent by an object to signal the occurrence of an action. The action could be caused by user interaction, such as a button click, or it could be raised by some other program logic, such as changing a property’s value. The object that raises the event is called the event sender.

The following example shows how to declare an event named ThresholdReached. The event is associated with the EventHandler delegate and raised in a method named OnThresholdReached.
```
class Counter
    {
        public event EventHandler ThresholdReached;

        protected virtual void OnThresholdReached(EventArgs e)
        {
            EventHandler handler = ThresholdReached;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        // provide remaining implementation for the class
    }
```
A delegate is a type that holds a reference to a method. A delegate is declared with a signature that shows the return type and parameters for the methods it references, and can hold references only to methods that match its signature. A delegate is thus equivalent to a type-safe function pointer or a callback. A delegate declaration is sufficient to define a delegate class
```
public delegate void ThresholdReachedEventHandler(ThresholdReachedEventArgs e);
```
Data that is associated with an event can be provided through an event data class.
```
public class ThresholdReachedEventArgs : EventArgs
    {
        public int Threshold { get; set; }
        public DateTime TimeReached { get; set; }
    }
```    
To respond to an event, you define an event handler method in the event receiver. This method must match the signature of the delegate for the event you are handling.
```
class Program
    {
        static void Main(string[] args)
        {
            Counter c = new Counter();
            c.ThresholdReached += c_ThresholdReached;

            // provide remaining implementation for the class
        }

        static void c_ThresholdReached(object sender, EventArgs e)
        {
            Console.WriteLine("The threshold was reached.");
        }
    }
```
