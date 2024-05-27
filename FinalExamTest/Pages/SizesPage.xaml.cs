using FinalExamTest.DataTransactions;
namespace FinalExamTest;

public partial class SizesPage : ContentPage
{
    int i = 0;
    int j = 0;
    int tempPriceMemory= 0;
    int tempPriceRam= 0;
    string[] memorySizes = { "0", "1TB", "2TB" };
    string[] ramSizes = { "0", "16", "32" };
	public SizesPage()
	{
		InitializeComponent();
        memorySize.Text = memorySizes[0];
        ramSize.Text = ramSizes[0];
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        totalPrice.Text = "Total Price: " + GlobalTrans.Total .ToString();
    }

    private void memorySizeMinus_Clicked(object sender, EventArgs e)
    {
        if( memorySize.Text == "0")
        {
            tempPriceMemory = 0;
        }
        else if (memorySize.Text == "1TB")
        {
            tempPriceMemory = 500; 
        }
        else if ( memorySize.Text == "2TB")
        {
            tempPriceMemory = 400;
        }
        if (memorySize.Text != "0")
        {
            i--;
        }
        
        memorySize.Text = memorySizes[i];
        GlobalTrans.Total -= tempPriceMemory;
        totalPrice.Text = GlobalTrans.Total.ToString();
        
    }

    private void memorySizePlus_Clicked(object sender, EventArgs e)
    {

        if (memorySize.Text == "2TB")
        {
            tempPriceMemory = 0;
        }
        else if (memorySize.Text == "1TB")
        {
            tempPriceMemory = -500;
            tempPriceMemory += 900;
        }
        else if (memorySize.Text == "0")
        {
            tempPriceMemory = 500;
        }
        if (memorySize.Text != "2TB")
        {
            i++;
        }
        memorySize.Text = memorySizes[i];
        GlobalTrans.Total += tempPriceMemory;
        totalPrice.Text = GlobalTrans.Total.ToString();
        tempPriceMemory = 0;
    }

    private void ramSizeMinus_Clicked(object sender, EventArgs e)
    {
        if (ramSize.Text == "0")
        {
            tempPriceRam = 0;
        }
        else if (memorySize.Text == "16")
        {
            tempPriceRam = 500;
        }
        else if (ramSize.Text == "32")
        {
            tempPriceRam = 400;
        }
        if (ramSize.Text != "0")
        {
            j--;
        }

        ramSize.Text = ramSizes[j];
        GlobalTrans.Total -= tempPriceRam;
        totalPrice.Text = GlobalTrans.Total.ToString();
    }

    private void ramSizePlus_Clicked(object sender, EventArgs e)
    {
        if (ramSize.Text == "32")
        {
            tempPriceMemory = 0;
        }
        else if (ramSize.Text == "16")
        {
            tempPriceRam = -500;
            tempPriceRam += 900;
        }
        else if (ramSize.Text == "0")
        {
            tempPriceRam = 500;
        }
        if (ramSize.Text != "32")
        {
            j++;
        }
        ramSize.Text = ramSizes[j];
        GlobalTrans.Total += tempPriceRam;
        totalPrice.Text = GlobalTrans.Total.ToString();
       
    }
}