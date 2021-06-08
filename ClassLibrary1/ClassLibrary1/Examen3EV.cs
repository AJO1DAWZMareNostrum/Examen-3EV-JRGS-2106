namespace Examen3EV_NS
{
    using System.Collections.Generic;

    /// <summary>
    /// Define a la clase <see cref="EstadisticaNotas" />.
    /// </summary>
    public class EstadisticaNotas  // esta clase nos calcula las estadísticas de un conjunto de notas 
    {
        /// <summary>
        /// Define los suspensos..
        /// </summary>
        private int suspensos;// Suspensos

        /// <summary>
        /// Define los aprobados..
        /// </summary>
        private int aprobados;// Aprobados

        /// <summary>
        /// Define los notables..
        /// </summary>
        private int notables;// Notables

        /// <summary>
        /// Define los sobresalientes..
        /// </summary>
        private int sobresalientes;// Sobresalientes

        /// <summary>
        /// Define a la media..
        /// </summary>
        private double media;// Nota media

        /// <summary>
        /// Gets or sets los suspensos.
        /// </summary>
        public int Suspensos
        { 
            get => suspensos; 
            set => suspensos = value; 
        }

        /// <summary>
        /// Gets or sets los aprobados.
        /// </summary>
        public int Aprobados 
        { 
            get => aprobados; 
            set => aprobados = value; 
        }

        /// <summary>
        /// Gets or sets los notables.
        /// </summary>
        public int Notables 
        { 
            get => notables; 
            set => notables = value; 
        }

        /// <summary>
        /// Gets or sets los sobresalientes.
        /// </summary>
        public int Sobresalientes 
        {
            get => sobresalientes; 
            set => sobresalientes = value; 
        }

        /// <summary>
        /// Gets or sets la media.
        /// </summary>
        public double Media
        { 
            get => media; 
            set => media = value; 
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="EstadisticaNotas"/> .
        /// </summary>
        public EstadisticaNotas()
        {
            Suspensos = Aprobados = Notables = Sobresalientes = 0;  // inicializamos las variables

            Media = 0.0;
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="EstadisticaNotas"/> class.
        /// </summary>
        /// <param name="listaNotas">La lista con todas las notas guardadas<see cref="List{int}"/>.</param>
        public EstadisticaNotas(List<int> listaNotas)
        {
            Media = 0.0;

            CalcularMedia(listaNotas);

            Media = Media / listaNotas.Count;
        }

        /// <summary>
        /// Para calcular la media de todas aquellas notas introducidas
        /// </summary>
        /// <param name="listaNotas">La lista con todas las notas guardadas<see cref="List{int}"/>.</param>
        private void CalcularMedia(List<int> listaNotas)
        {
            for (int i = 0; i < listaNotas.Count; i++)
            {
                if (listaNotas[i] < 5)
                {
                    Suspensos++; // Por debajo de 5 suspenso
                }
                else if (listaNotas[i] > 5 && listaNotas[i] < 7)
                {
                    Aprobados++; // Nota para aprobar: 5
                }
                else if (listaNotas[i] > 7 && listaNotas[i] < 9)
                {
                    Notables++; // Nota para notable: 7
                }
                else if (listaNotas[i] > 9)
                {
                    Sobresalientes++; // Nota para sobresaliente: 9
                }

                Media = Media + listaNotas[i];
            }
        }

        /// <summary>
        /// Función que calcula la estadística general y la media de todas las notas
        /// </summary>
        /// <param name="listaNotas">La lista con todas las notas guardadas<see cref="List{int}"/>.</param>
        /// <returns>La Media <see cref="double"/>.</returns>
        public double CalcularEstadisticas(List<int> listaNotas)
        {
            Media = 0.0;

            // TODO: hay que modificar el tratamiento de errores para generar excepciones
            //
            if (listaNotas.Count <= 0)
            {
                // Si la lista no contiene elementos, devolvemos un error
                return -1;
            }

            for (int i = 0; i < 10; i++)
            {
                if (listaNotas[i] < 0 || listaNotas[i] > 10)  // comprobamos que las not están entre 0 y 10 (mínimo y máximo), si no, error
                {
                    return -1;
                }
            }

            CalcularMedia(listaNotas);

            Media = Media / listaNotas.Count;

            return Media;
        }
    }
}
