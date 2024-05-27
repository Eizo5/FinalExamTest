using FinalExamTest.DataTransactions;

namespace FinalExamTest;

public partial class RadioPage : ContentPage
{
    int processorTotal = 0;
    int rtxTotal = 0;
	public RadioPage()
	{
		InitializeComponent();
	}



    private void i3_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (processorTotal > 0 && GlobalTrans.Total > 0)
        {
            GlobalTrans.Total -= processorTotal;
        }

        if (i3.IsChecked)
        {
            processorTotal = 30;
            GlobalTrans.Processor = "i3";
        }

        { }
        GlobalTrans.Total += processorTotal;
        totalPrice.Text = "Total Price: " + GlobalTrans.Total.ToString();
    }

    private void i5_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (processorTotal > 0 && GlobalTrans.Total > 0)
        {
            GlobalTrans.Total -= processorTotal;

        }

        if (i5.IsChecked)
        {
            processorTotal = 50;
            GlobalTrans.Processor = "i5";
        }
        GlobalTrans.Total += processorTotal;
        totalPrice.Text = "Total Price: " + GlobalTrans.Total.ToString();
    }

    private void i7_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (processorTotal > 0 && GlobalTrans.Total > 0)
        {
            GlobalTrans.Total -= processorTotal;
        }

        if (i7.IsChecked)
        {
            processorTotal = 70;
            GlobalTrans.Processor = "i7";
        }
        GlobalTrans.Total += processorTotal;
        totalPrice.Text = "Total Price: " + GlobalTrans.Total.ToString();
    }

    private void rtx36_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (rtxTotal > 0 && GlobalTrans.Total > 0)
        {
            GlobalTrans.Total -= rtxTotal;
        }
        if (rtx36.IsChecked)
        {
            rtxTotal = 200;
            GlobalTrans.RTX = "RTX3060";
        }

        GlobalTrans.Total += rtxTotal;
        totalPrice.Text = "Total Price: " + GlobalTrans.Total.ToString();
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        totalPrice.Text = "Total Price: " + GlobalTrans.Total.ToString();
    }
    private void rtx36ti_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (rtxTotal > 0 && GlobalTrans.Total > 0)
        {
            GlobalTrans.Total -= rtxTotal;
        }
        if (rtx36ti.IsChecked)
        {
            rtxTotal = 400;
            GlobalTrans.RTX = "RTX3060ti";
        }

        GlobalTrans.Total += rtxTotal;
        totalPrice.Text = "Total Price: " + GlobalTrans.Total.ToString();

    }

    private void rtx37_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (rtxTotal > 0 && GlobalTrans.Total > 0)
        {
            GlobalTrans.Total -= rtxTotal;
        }
        if (rtx37.IsChecked)
        {
            rtxTotal = 600;
            GlobalTrans.RTX = "RTX3070";
        }

        GlobalTrans.Total += rtxTotal;
        totalPrice.Text = "Total Price: " + GlobalTrans.Total.ToString();

    }

    private void mouse_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
       if (mouse.IsChecked)
        {
            GlobalTrans.Total += 400;
        }
       else
        {
            GlobalTrans.Total -= 400;
        }
        totalPrice.Text = "Total Price: " + GlobalTrans.Total.ToString();

    }

    private void keyboard_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (keyboard.IsChecked)
        {
            GlobalTrans.Total += 400;
        }
        else
        {
            GlobalTrans.Total -= 400;
        }
        totalPrice.Text = "Total Price: " + GlobalTrans.Total.ToString();
    }

    private void headphones_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (headphones.IsChecked)
        {
            GlobalTrans.Total += 400;
        }
        else
        {
            GlobalTrans.Total -= 400;
        }
        totalPrice.Text = "Total Price: " + GlobalTrans.Total.ToString();
    }
}