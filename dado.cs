using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ldado
{
    class Dado
    {
        Random a = new Random();
        public string Lanzar()
        {
            string muestra = "";
            int cont1 = 0;
            int cont2 = 0;
            int cont3 = 0;
            int cont4 = 0;
            int cont5 = 0;
            int cont6 = 0;
            for(int i = 1; i <= 100; i++) { 
            int r = a.Next(1, 7);
            if (r == 1){ cont1++; }
            else{ if (r == 2) { cont2++;  }
                else { if (r == 3) { cont3++; } }
                if (r == 4) { cont4++;  }
                else { if (r == 5) { cont5++; } }
                if (r == 6) { cont6++;  }
            }
            }//for de los 100 lanzamientos
            muestra += "Cara 1 cayo " + cont1 + " veces" + Environment.NewLine;
            muestra += "Cara 2 cayo " + cont2 + " veces" + Environment.NewLine;
            muestra += "Cara 3 cayo " + cont3 + " veces" + Environment.NewLine;
            muestra += "Cara 4 cayo " + cont4 + " veces" + Environment.NewLine;
            muestra += "Cara 5 cayo " + cont5 + " veces" + Environment.NewLine;
            muestra += "Cara 6 cayo " + cont6 + " veces" + Environment.NewLine;
            return muestra;
        }
        Random b = new Random();
        Random c = new Random();
        public string Suma()
        { 
            string muestra= "";
            int res;
            int res2;
            int suma;
            int cont1 = 0;
            int cont2 = 0;
            int cont3 = 0;
            int cont4 = 0;
            int cont5 = 0;
            int cont6 = 0;
            int cont7 = 0;
            int cont8 = 0;
            int cont9 = 0;
            int cont10 = 0;
            int cont11 = 0;
            for (int i = 1; i <= 100; i++)
            {
                int r = b.Next(1, 7);
                int ra = c.Next(1, 7);
                res = r;
                res2 = ra;
                suma = res + res2;
                if (suma == 2) { cont1++; }
                else { if (suma == 3) { cont2++; }
                    else { if (suma == 4) { cont3++; }
                        else { if (suma == 5) { cont4++; }
                            else { if (suma == 6) { cont5++; }
                                else { if (suma == 7) { cont6++; }
                                    else { if (suma == 8) { cont7++; }
                                        else { if (suma == 9) { cont8++; }
                                            else { if (suma == 10) { cont9++; }
                                                else { if (suma == 11) { cont10++; }
                                                    else { if (suma == 12) { cont11++; } }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }//for de los 100 lanzamientos
            muestra += "La suma de los dados fue 2 el siguiente numero de veces: " + cont1 + Environment.NewLine;
            muestra += "La suma de los dados fue 3 el siguiente numero de veces: " + cont2 + Environment.NewLine;
            muestra += "La suma de los dados fue 4 el siguiente numero de veces: " + cont3 + Environment.NewLine;
            muestra += "La suma de los dados fue 5 el siguiente numero de veces: " + cont4 + Environment.NewLine;
            muestra += "La suma de los dados fue 6 el siguiente numero de veces: " + cont5 + Environment.NewLine;
            muestra += "La suma de los dados fue 7 el siguiente numero de veces: " + cont6 + Environment.NewLine;
            muestra += "La suma de los dados fue 8 el siguiente numero de veces: " + cont7 + Environment.NewLine;
            muestra += "La suma de los dados fue 9 el siguiente numero de veces: " + cont8 + Environment.NewLine;
            muestra += "La suma de los dados fue 10 el siguiente numero de veces: " + cont9 + Environment.NewLine;
            muestra += "La suma de los dados fue 11 el siguiente numero de veces: " + cont10 + Environment.NewLine;
            muestra += "La suma de los dados fue 12 el siguiente numero de veces: " + cont11 + Environment.NewLine;
            return muestra;
        }
    }
}
