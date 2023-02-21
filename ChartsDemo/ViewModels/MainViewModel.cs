using ChartsDemo.Helpers;

namespace ChartsDemo.ViewModels;

public partial class MainViewModel : BaseViewModel
{

    [ObservableProperty]
    private ObservableCollection<ChartValue> _incomeSeries;

    [ObservableProperty]
    private ObservableCollection<ChartValue> _expenseSeries;

    public void LoadData()
    {
        IncomeSeries = GetIncomeSeries();
        ExpenseSeries = GetExpenseSeries();
    }

    private ObservableCollection<ChartValue> GetExpenseSeries()
    {
        ObservableCollection<ChartValue> series = new ObservableCollection<ChartValue>();

        for (int i = 0; i < 25; i++)
        {
            series.Add(new ChartValue() { Label = $"Expense {i}", Value = i*10 });
        }

        return series;
    }

    private ObservableCollection<ChartValue> GetIncomeSeries()
    {
        ObservableCollection<ChartValue> series = new ObservableCollection<ChartValue>();

        for (int i = 0; i < 15; i++)
        {
            series.Add(new ChartValue() { Label = $"Income {i}", Value = i * 10 });
        }

        return series;
    }
}
