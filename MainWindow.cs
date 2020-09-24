using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    int n;
    int n1;
    int n2;
    int res;
    bool operatorFlag;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        numbox.IsFocus = true;
        Pango.FontDescription font = new Pango.FontDescription();
        font.Size = 40000;
        numbox.ModifyFont(font);
        numbox.Alignment = 1;
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)                              
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void SevenClicked(object sender, EventArgs e)
    {
        n = 7;
        if (operatorFlag == true)
        {
            n2 = n;
        }
        else
        {
            n1 = n;
        }
         
        numbox.Text += Convert.ToString(n);
    }

    protected void KeyPress(object sender, KeyPressEventArgs e)
    {
        EventArgs args = new EventArgs(); 
        if (e.Event.Key == Gdk.Key.L7)
        {
            SevenClicked(sender,args);
        }
    }
}
