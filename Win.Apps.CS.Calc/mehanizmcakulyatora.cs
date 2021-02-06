using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Win.Apps.CS.Calc
{
    class mehanizmcalkulyatora
	{
		public enum Deystvie:int
		{
			NeopredelDeystvie = 0,
			Slojenie = 1,
			Vichitanie = 2,
			Umnojenie = 3,
			Delenie = 4,
            Exponentiation = 5,
            SquareRoot = 6,
            RegressiveNum = 7,
            SquareNumber = 8,
			Factorial = 9,
			CubicRoot = 10,
			bLogarithm = 11
		}

		/// <summary>
		/// Статические переменные:
		/// extent - перевенная квадрата
		/// peremennayaMinus - переменная для изменения числа в положительное или отрицательное
		/// </summary>
		#region Constants
		private static double peremennayaMinus = -1;
		#endregion



		/// <summary>
		/// Список переменный и булевых значений:
		/// resultatVichisleniy - результат вычеслений
		///  resultatOutput - результат нажатия кнопки с цифрой
		///  tekusheeDeystvieCalculatora - действие которое будет выполнятся
		///  pervoeChislo - первое введеное число
		///  vtoroeChislo - второе введеное число
		///  dobavlenierazryada - 
		///  ChislosTochkoy - проверка на нажатие кнопки
		/// </summary>

		private static double resultatVichisleniy;
		private static string resultatOutput;
		private static Deystvie tekusheeDeystvieCalculatora;
		private static double pervoeChislo;
		private static double vtoroeChislo;
		private static bool dobavlenierazryada;
		private static bool ChislosTochkoy;
 

		public mehanizmcalkulyatora ()
		{
			ChislosTochkoy = false;
			dobavlenierazryada = false;
		}
					
		public static string chislonaEkrane (string najatayaKlavisha)
		{
			resultatOutput = resultatOutput + najatayaKlavisha;
			return (resultatOutput);
		}


        public static void DeystvieCalculatora (Deystvie peremenDeystviya)
		{
			try
			{
				if (resultatOutput != "" && !dobavlenierazryada)
				{
					pervoeChislo = System.Convert.ToDouble (resultatOutput);
					tekusheeDeystvieCalculatora = peremenDeystviya;
					resultatOutput = "";
					ChislosTochkoy = false;
				}			
			}
		
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				
			}
		}


		/// <summary>
		/// ZnakChisla - Изменение числа на +/-
		/// </summary>

		public static string ZnakChisla ()
		{
			double tekusheeChislo;

			if (resultatOutput != "")
			{
				tekusheeChislo = System.Convert.ToDouble (resultatOutput);
				resultatOutput = System.Convert.ToString(tekusheeChislo * peremennayaMinus);
			}
		
			return (resultatOutput);
		}

		/// <summary>
		/// Метод ставист точку после числа
		/// </summary>	

		public static string ZnakTochki ()
		{
			if (!ChislosTochkoy && !dobavlenierazryada)
			{
				if (resultatOutput != null)
					resultatOutput = resultatOutput + ",";
				else
					resultatOutput = "0,";

				ChislosTochkoy = true;
			}

			return (resultatOutput);
		}

		/// <summary>
		/// SinglePressing - обрабатывающий одно число и возвращает результат вычислений
		/// ZnakRavno - брабатывает 2 числа и возвращает результат вычислений
		/// </summary>

		public static string SinglePressing()
		{
			bool proverkaOshibok = false;

            dobavlenierazryada = true;

            switch (tekusheeDeystvieCalculatora)
            {
                case Deystvie.SquareRoot:
                    resultatVichisleniy = Math.Sqrt(pervoeChislo);
                    proverkaOshibok = true;
                    break;

                case Deystvie.RegressiveNum:
                    resultatVichisleniy = MathemExpress.RegresNum(pervoeChislo);
                    proverkaOshibok = true;
                    break;

                case Deystvie.SquareNumber:
                    resultatVichisleniy = MathemExpress.SquareNumber(pervoeChislo);
                    proverkaOshibok = true;
                    break;

				case Deystvie.Factorial:
					resultatVichisleniy = MathemExpress.Factorial(pervoeChislo);
					proverkaOshibok = true;
					break;

				case Deystvie.CubicRoot:
					resultatVichisleniy = MathemExpress.CubicRoot(pervoeChislo);
					proverkaOshibok = true;
					break;

				default:
                    proverkaOshibok = false;
                    break;
            }

            if (proverkaOshibok)
                resultatOutput = System.Convert.ToString(resultatVichisleniy);

            return (resultatOutput);
        }


        public static string ZnakRavno ()
		{
			bool proverkaOshibok = false;

			if (resultatOutput != "")
			{
				vtoroeChislo = System.Convert.ToDouble (resultatOutput);
				dobavlenierazryada = true; 

				switch (tekusheeDeystvieCalculatora)
				{
					case Deystvie.NeopredelDeystvie:
						proverkaOshibok = false;
						break;

					case Deystvie.Slojenie:
						resultatVichisleniy = MathemExpress.Sum(pervoeChislo, vtoroeChislo);
						proverkaOshibok = true;
						break;

					case Deystvie.Vichitanie:
						resultatVichisleniy = MathemExpress.Subtraction(pervoeChislo, vtoroeChislo);
						proverkaOshibok = true;
						break;

					case Deystvie.Umnojenie:
						resultatVichisleniy = MathemExpress.Multiplication(pervoeChislo, vtoroeChislo);
						proverkaOshibok = true;
						break;

					case Deystvie.Delenie:
						resultatVichisleniy = MathemExpress.Division(pervoeChislo, vtoroeChislo);
						proverkaOshibok = true;
						break;

                    case Deystvie.Exponentiation:
                        resultatVichisleniy = Math.Pow(pervoeChislo, vtoroeChislo);
                        proverkaOshibok = true;
                        break;

					case Deystvie.bLogarithm:
						resultatVichisleniy = Math.Log(pervoeChislo, vtoroeChislo);
						proverkaOshibok = true;
						break;

					default:
						proverkaOshibok = false;
						break;
				}

				if (proverkaOshibok)
					resultatOutput = System.Convert.ToString (resultatVichisleniy);
			}
			
			return (resultatOutput);
		}

		/// <summary>
		/// Sbros - Сброс параметров в стандартным значениям
		/// </summary>

		public static void Sbros ()
		{
			resultatVichisleniy = 0;
			pervoeChislo = 0;
			vtoroeChislo = 0;
			resultatOutput = "";
			tekusheeDeystvieCalculatora = Deystvie.NeopredelDeystvie;
			ChislosTochkoy = false;
			dobavlenierazryada = false;			
		}
	}
}

