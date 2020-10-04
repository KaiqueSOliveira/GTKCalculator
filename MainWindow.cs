using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    float n;
    float n1;
    float n2;
    float res;
    bool operatorFlag;
    bool noneFlag = false;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        numbox.IsFocus = true;
        Pango.FontDescription font = new Pango.FontDescription();
        font.Size = 40000;
        numbox.ModifyFont(font);
        numbox.Alignment = 1;
        numbox.Position = 0;
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)                              
    {
        Application.Quit();
        a.RetVal = true;
    }



    // On Key Press Events

    protected void OnNumboxKeyPressEvent(object o, KeyPressEventArgs args)
    {
        //EventArgs arg = new EventArgs();
        switch (args.Event.Key)
        {
            case Gdk.Key.Key_0:
            case Gdk.Key.KP_0:
                n = 0;
                break;
            case Gdk.Key.Key_1:
            case Gdk.Key.KP_1:
                n = 1;
                break;
            case Gdk.Key.Key_2:
            case Gdk.Key.KP_2:
                n = 2;
                break;
            case Gdk.Key.Key_3:
            case Gdk.Key.KP_3:
                n = 3;
                break;
            case Gdk.Key.Key_4:
            case Gdk.Key.KP_4:
                n = 4;
                break;
            case Gdk.Key.Key_5:
            case Gdk.Key.KP_5:
                n = 5;
                break;
            case Gdk.Key.Key_6:
            case Gdk.Key.KP_6:
                n = 6;
                break;
            case Gdk.Key.Key_7:
            case Gdk.Key.KP_7:
                n = 7;
                break;
            case Gdk.Key.Key_8:
            case Gdk.Key.KP_8:
                n = 8;
                break;
            case Gdk.Key.Key_9:
            case Gdk.Key.KP_9:
                n = 9;
                break;
            case Gdk.Key.BackSpace:                  //<<<<<----------------------------------
                n = 9;
                break;
            default:
                noneFlag = true;
                break;
        }

        if (noneFlag == false)
        {
            numbox.Text += Convert.ToString(n);
        }

        noneFlag = false;
        numbox.Position = -1;

    }


  

        // On Click Events

    protected void OnBtn7Clicked(object sender, EventArgs e)
    {
        n = 7;
        numbox.Text += Convert.ToString(n);
        numbox.Position = -1;
    }
    protected void OnBtn8Clicked(object sender, EventArgs e)
    {
        n = 8;
        numbox.Text += Convert.ToString(n);
        numbox.Position = -1;
    }

    protected void OnSumClicked(object sender, EventArgs e)
    {


    }

}
