using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Diagnostics;

public class Product : INotifyPropertyChanged
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string[] ImageURL { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
    public bool IsBestseller { get; set; }

    private bool _isFavourite;
    public bool isFavourite
    {
        get => _isFavourite;
        set
        {
            if (_isFavourite != value)
            {
                _isFavourite = value;
                Debug.WriteLine($"✅ {Name} isFavourite updated to: {isFavourite}");
                OnPropertyChanged();
            }
        }
    }


    private string _likeImageValue = "heart.png";
    public string LikeImageValue
    {
        get => _likeImageValue;
        set
        {
            if (_likeImageValue != value)
            {
                _likeImageValue = value;
                OnPropertyChanged();
            }
        }
    }

    public ICommand LikeCommand { get; }

    public Product()
    {
        LikeCommand = new Command(ToggleLike);
    }

    private void ToggleLike()
    {
        isFavourite = !isFavourite;  // ✅ Toggle the favourite state
        LikeImageValue = isFavourite ? "hearttrue.png" : "heart.png";

        Debug.WriteLine($"🎯 Toggle Like: {Name} isFavourite = {isFavourite}");
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
