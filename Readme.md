# Currency Apps

aplikasi ini bisa mencovert dari mata uang Dolar 
menjadi rupiah dengan nilai Rp 15.000

# Scope & Functionalities
- User dapat memasukan angka
- user dapat menyentuh tombol hitung
- user dapat mendapat invalid jika yang di masukan text

# How does it Work?
Di awali dengan method 'Mainwindow' pada class main windows

''' C#
public MainWindow()
        {
            InitializeComponent();
            currency = new CurrencyController();
        }
'''
Logika perhitungan terdapat dari class 'CurrencyControllr.cs' Sebgai berikut
public string usdToIdr(string nominal)
        {
            var nominalDouble = Convert.ToDouble(nominal);
            var result = nominalDouble * 15000;

            return Convert.ToString(result);
        }
'''
