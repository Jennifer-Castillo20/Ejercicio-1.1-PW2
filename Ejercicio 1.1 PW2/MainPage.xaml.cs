using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio_1._1_PW2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnNumber1TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.NewTextValue))
            {
                // Verifica si el nuevo texto contiene solo caracteres numéricos.
                if (!IsNumeric(e.NewTextValue))
                {
                    // Si no es numérico, elimina el último carácter ingresado.
                    txtNum1.Text = e.OldTextValue;
                }
            }
        }

        // -------- SOLO ACEPTE VALORES NUMERICOS-------
        private void OnNumber2TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.NewTextValue))
            {
                // Verifica si el nuevo texto contiene solo caracteres numéricos.
                if (!IsNumeric(e.NewTextValue))
                {
                    // Si no es numérico, elimina el último carácter ingresado.
                    txtNum2.Text = e.OldTextValue;
                }
            }
        }

        // Función para verificar si una cadena es numérica.
        private bool IsNumeric(string value)
        {
            return double.TryParse(value, out _);
        }


        // -------OPERACIONES-------
        private void SumaClicked(object sender, EventArgs e)
        {
            // Aquí puedes agregar la lógica para realizar la suma.
            if (double.TryParse(txtNum1.Text, out double num1) && double.TryParse(txtNum2.Text, out double num2))
            {
                double resultado = num1 + num2;
                DisplayAlert("Resultado", $"La suma es: {resultado}", "Aceptar");
            }
            else
            {
                DisplayAlert("Error", "Ingresa números válidos", "Aceptar");
            }
        }

        private void RestaClicked(object sender, EventArgs e)
        {
            // Aquí puedes agregar la lógica para realizar la suma.
            if (double.TryParse(txtNum1.Text, out double num1) && double.TryParse(txtNum2.Text, out double num2))
            {
                double resultado = num1 - num2;
                DisplayAlert("Resultado", $"La resta es: {resultado}", "Aceptar");
            }
            else
            {
                DisplayAlert("Error", "Ingresa números válidos", "Aceptar");
            }
        }

        private void MultiClicked(object sender, EventArgs e)
        {
            // Aquí puedes agregar la lógica para realizar la suma.
            if (double.TryParse(txtNum1.Text, out double num1) && double.TryParse(txtNum2.Text, out double num2))
            {
                double resultado = num1 * num2;
                DisplayAlert("Resultado", $"La multiplicacion es: {resultado}", "Aceptar");
            }
            else
            {
                DisplayAlert("Error", "Ingresa números válidos", "Aceptar");
            }
        }

        private void DivisionClicked(object sender, EventArgs e)
        {
            // Aquí puedes agregar la lógica para realizar la suma.
            if (double.TryParse(txtNum1.Text, out double num1) && double.TryParse(txtNum2.Text, out double num2))
            {
                double resultado = num1 / num2;
                DisplayAlert("Resultado", $"La division es: {resultado}", "Aceptar");
            }
            else
            {
                DisplayAlert("Error", "Ingresa números válidos", "Aceptar");
            }
        }

    }



}
