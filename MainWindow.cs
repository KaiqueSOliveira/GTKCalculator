using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    double n;
    double n1;
    double n2;
    double res;
    bool operatorFlag;
    bool noneFlag = false;
    string op;
    string sig;

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
            case Gdk.Key.KP_Divide:
                object sender3 = new object();
                EventArgs arg3 = new EventArgs();
                OnDivClicked(sender3, arg3);
                return;
            case Gdk.Key.KP_Add:
                object sender = new object();
                EventArgs arg = new EventArgs();
                OnSumClicked(sender,arg);
                return;
            case Gdk.Key.minus:
                object sender1 = new object();
                EventArgs arg1 = new EventArgs();
                OnMinusClicked(sender1, arg1);
                return;;
            case Gdk.Key.KP_Multiply:
                object sender2 = new object();
                EventArgs arg2 = new EventArgs();
                OnMultClicked(sender2, arg2);
                return;
            case Gdk.Key.KP_Enter:                            // Not working
                object sender4 = new object();
                EventArgs arg4 = new EventArgs();
                OnEqualClicked(sender4, arg4);
                return;
            case Gdk.Key.comma:
            case Gdk.Key.KP_Separator:
                numbox.Text += ",";
                numbox.Position = -1;
                return;
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


    protected void OnBtn9Clicked(object sender, EventArgs e)
    {
        n = 9;
        numbox.Text += Convert.ToString(n);
        numbox.Position = -1;
    }

    protected void OnBtn4Clicked(object sender, EventArgs e)
    {
        n = 4;
        numbox.Text += Convert.ToString(n);
        numbox.Position = -1;
    }

    protected void OnBtn5Clicked(object sender, EventArgs e)
    {
        n = 5;
        numbox.Text += Convert.ToString(n);
        numbox.Position = -1;
    }

    protected void OnBtn6Clicked(object sender, EventArgs e)
    {
        n = 6;
        numbox.Text += Convert.ToString(n);
        numbox.Position = -1;
    }

    protected void OnBtn1Clicked(object sender, EventArgs e)
    {
        n = 1;
        numbox.Text += Convert.ToString(n);
        numbox.Position = -1;
    }

    protected void OnBtn2Clicked(object sender, EventArgs e)
    {
        n = 2;
        numbox.Text += Convert.ToString(n);
        numbox.Position = -1;
    }

    protected void OnBtn3Clicked(object sender, EventArgs e)
    {
        n = 3;
        numbox.Text += Convert.ToString(n);
        numbox.Position = -1;
    }

    protected void OnBtnZeroClicked(object sender, EventArgs e)
    {
        n = 0;
        numbox.Text += Convert.ToString(n);
        numbox.Position = -1;
    }
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
        if (operatorFlag == false)
        {
            n1 = Convert.ToDouble(numbox.Text);
            operatorFlag = true;
            sig = " + ";
            resbox.Text = numbox.Text + sig;
            numbox.Text = " ";
            op = "sum";
        }

    }

    protected void OnMinusClicked(object sender, EventArgs e)
    {
        if (operatorFlag == false)
        {
            n1 = Convert.ToDouble(numbox.Text);
            operatorFlag = true;
            sig = " - ";
            resbox.Text = numbox.Text + sig;
            numbox.Text = "";
            op = "sub";
        }

    }
    protected void OnMultClicked(object sender, EventArgs e)
    {
        if (operatorFlag == false)
        {
            n1 = Convert.ToDouble(numbox.Text);
            operatorFlag = true;
            sig = " x ";
            resbox.Text = numbox.Text + sig;
            numbox.Text = "";
            op = "mult";
        }
    }
    protected void OnDivClicked(object sender, EventArgs e)
    {
        if (operatorFlag == false)
        {
            n1 = Convert.ToDouble(numbox.Text);
            operatorFlag = true;
            sig = " / ";
            resbox.Text = numbox.Text + sig;
            numbox.Text = "";
            op = "div";
        }
    }
    protected void OnExpClicked(object sender, EventArgs e)
    {
        if (operatorFlag == false)
        {
            n1 = Convert.ToDouble(numbox.Text);
            operatorFlag = true;
            sig = " ^ ";
            resbox.Text = numbox.Text + sig;
            numbox.Text = "";
            op = "exp";
        }
    }

    protected void OnRootClicked(object sender, EventArgs e)
    {
        if (operatorFlag == false)
        {
            n1 = Convert.ToDouble(numbox.Text);
            operatorFlag = true;
            sig = " √ ";
            resbox.Text = numbox.Text + sig;
            numbox.Text = "";
            op = "root";
        }
    }

    protected void OnPercentageClicked(object sender, EventArgs e)
    {
        n1 = Convert.ToDouble(numbox.Text);
        n2 = Convert.ToDouble(numbox.Text);
        n2 = n1;
        res = n1/100;
        resbox.Text = Convert.ToString(res);
        numbox.Text = Convert.ToString(res);
        n2 = 0;
        operatorFlag = false;
    }

    protected void OnCleanClicked(object sender, EventArgs e)
    {
        numbox.Text = "";
        resbox.Text = "";
        n1 = 0;
        n2 = 0;
        res = 0;
        operatorFlag = false;
        op = "";
    }
    protected void OnCommaClicked(object sender, EventArgs e)
    {
        numbox.Text += ",";
        numbox.Position = -1;

    }


    protected void OnEqualClicked(object sender, EventArgs e)
    {
        if (operatorFlag == true)
        {
            n2 = Convert.ToDouble(numbox.Text);
            operatorFlag = true;

            switch (op)
            {
                case "sum":
                    res = n1 + n2;
                    operatorFlag = false;
                    break;
                case "sub":
                    res = n1 - n2;
                    operatorFlag = false;
                    break;
                case "div":
                    if (Convert.ToInt32(n1) == 0 | Convert.ToInt32(n2) == 0)
                    {
                        resbox.Text = "Error";
                        numbox.Text = "";
                        n1 = 0;
                        n2 = 0;
                        op = "";
                    }
                    else
                    {
                        res = n1 / n2;
                    }
                    operatorFlag = false;
                    break;
                case "mult":
                    res = n1 * n2;
                    operatorFlag = false;
                    break;
                case "root":
                    res = Math.Pow(n2, 1 / n1);
                    operatorFlag = false;
                    break;
                case "exp":
                    res = Math.Pow(n1, n2);
                    operatorFlag = false;
                    break;

            }


            if (resbox.Text != "Error")
            {
                resbox.Text = Convert.ToString(n1) + sig + numbox.Text + " = " + Convert.ToString(res);
                numbox.Text = Convert.ToString(res);
            }
        }
    }
}
