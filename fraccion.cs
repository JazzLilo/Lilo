using System;
using System.Collections.Generic;
using System.Text;

namespace Fraccion
{
    class fraccion
    {
        private int num, den;

        public int Den
        {
            get { return den; }
            set { den = value; }
        }

        public int Num
        {
            get { return num; }
            set { num = value; }
        }

        public fraccion(int n, int d)
        {
            num = n; den = d;
        }
        public void mostrar()
        {
            Console.Write("\n La fraccion es:");
            Console.WriteLine(num + "/" + den);
        }
        public static fraccion operator +(fraccion p, fraccion q)
        {
            int nume = (p.num * q.den) + (p.den * q.num);
            int deno = p.den * q.den;
            return (new fraccion(nume, deno));
        }
        public static fraccion operator -(fraccion p, fraccion q)
        {
            int nume = (p.num * q.den) - (p.den * q.num);
            int deno = p.den * q.den;
            return (new fraccion(nume, deno));
        }
        public static fraccion operator *(fraccion p, fraccion q)
        {
            int nume = p.num * q.num;
            int deno = p.den * q.den;
            return (new fraccion(nume, deno));
        }
        public static fraccion operator /(fraccion p, fraccion q)
        {
            int nume = p.num * q.den;
            int deno = p.den * q.num;
            return (new fraccion(nume, deno));
        }
        private int mcd()
        {
            int u = Math.Abs(num);
            int v = Math.Abs(den);
            if (v == 0)
            {
                return u;
            }
            int r;
            while (v != 0)
            {
                r = u % v;
                u = v;
                v = r;
            }
            return u;
        }
        public void simplificar()
        {
            int dividir = this.mcd();
            Console.WriteLine(dividir);
            num = num / dividir;
            den = den / dividir;
            mostrar();
        }
        public void Leer()
        {
            num = Int32.Parse(Console.ReadLine());
            den = Int32.Parse(Console.ReadLine());
        }
    }
}
