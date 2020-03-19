using System;
using System.Collections.Generic;
using System.Text;

namespace ReporteU2
{
    public class Reporte
    {
        private int id;
        private string cliente;
        private double limite;
        private double compras;
        private double abonos;
        private double saldo;

        public Reporte(int id, string cliente,
                        double limite, double compras,
                        double abonos, double saldo)
        {
            this.id = id;
            this.cliente = cliente;
            this.limite = limite;
            this.compras = compras;
            this.abonos = abonos;
            this.saldo = saldo;
        }

        public Reporte(int id, string cliente)
        {
            this.id = id;
            this.cliente = cliente;
        }

        public int setId(int id) {

            return this.id = id;
        }
        public int getId() {

            return this.id;
        }

        public string setCliente(string cliente)
        {

            return this.cliente = cliente;
        }
        public string getCliente()
        {
            return this.cliente;
        }
        public double setLimite(double limite)
        {
            return this.limite = limite;
        }
        public double getLimite()
        {
            return this.limite;
        }
        public double setCompras(double compras)
        {
            return this.compras = compras;
        }
        public double getCompras()
        {
            return this.compras;
        }
        public double setAbonos(double abonos)
        {
            return this.abonos = abonos;
        }
        public double getAbonos()
        {
            return this.abonos;
        }
        public double setSaldo(double saldo)
        {
            return this.saldo = saldo;
        }
        public double getSaldo()
        {
            return this.saldo;
        }
        public override string ToString()
        {
            return "id="+ this.id+"\ncliente="+this.cliente+"\nLimite="+this.limite+"\ncompras="+this.compras+"\nabonos="+this.abonos+"\nsaldo="+this.saldo;
        }




    }
}
