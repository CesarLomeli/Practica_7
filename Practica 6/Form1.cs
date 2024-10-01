namespace Practica_6
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            var archivos = llenarArchivos();
            correrMejorAjuste(archivos);
            correrPrimerAjuste(archivos);
            correrPeorAjuste(archivos);
            correrSiguienteAjuste(archivos);
        }

        public List<Memoria> llenarMemoria()
        { 
            Memoria memoria = new Memoria();
            List<Memoria> lista = new List<Memoria>();
            listMemoriaOri.Items.Clear();
            foreach (var item in memoria.cargarMemoria())
            {
                lista.Add(item);
                listMemoriaOri.Items.Add(item.tamano+" Kb " + (item.estatus == false ? "Libre" : "Ocupada"));
            }
            return lista;
        }

        public List<archivos> llenarArchivos()
        {
            archivos archivos = new archivos();
            List<archivos> Listarchivos = new List<archivos>();
            foreach(var item in archivos.cargarArchivos("C:\\Users\\cesar\\OneDrive\\Documentos\\School\\Seminario de sistemas operativos\\Practica 6\\archivos.txt"))
            {
                Listarchivos.Add(item);
                listBoxArchivos.Items.Add(item.nombre + " tamaño: "+ item.tamano + " kb");
            }
            return Listarchivos;
        }
        public void correrPrimerAjuste(List<archivos> archivos)
        {
            List<Memoria> memoria = new List<Memoria>();
            memoria = llenarMemoria();
            primerAjuste obj = new primerAjuste();
            foreach (var item in obj.algoritmo(archivos, memoria))
            {
                listBoxPrimerAjuste.Items.Add(item.tamano + " kb " + (item.estatus == true ? item.archivo.nombre : "Libre"));
            }
        }
        public void correrMejorAjuste(List<archivos> archivos)
        {
            List<Memoria> memoria = new List<Memoria>();
            memoria = llenarMemoria();
            mejorAjuste obj = new mejorAjuste();
            foreach (var item in obj.algoritmo(archivos, memoria))
            {
                listBoxMejorAjuste.Items.Add(item.tamano + " kb " + (item.estatus == true ? item.archivo.nombre : "Libre"));
            }
        }
        public void correrPeorAjuste(List<archivos> archivos)
        {
            List<Memoria> memoria = new List<Memoria>();
            memoria = llenarMemoria();
            peorAjuste obj = new peorAjuste();
            foreach(var item in obj.algoritmo(archivos, memoria))
            {
                listBoxPeorAjuste.Items.Add(item.tamano + " kb " + (item.estatus == true ? item.archivo.nombre : "Libre"));
            }
        }
        public void correrSiguienteAjuste(List<archivos> archivos)
        {
            List<Memoria> memoria = new List<Memoria>();
            memoria = llenarMemoria();
            siguienteAjuste obj = new siguienteAjuste();
            foreach(var item in obj.algoritmo(archivos, memoria))
            {
                listBoxSiguienteAjuste.Items.Add(item.tamano + " kb " + (item.estatus == true ? item.archivo.nombre : "Libre"));
            }
        }
    }
}
