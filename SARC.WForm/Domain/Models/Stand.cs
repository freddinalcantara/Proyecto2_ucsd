namespace SARC.WForm.Domain.Models
{
    public class Stand
    {
        public int Id { get; set; }
        [System.ComponentModel.DisplayName("Mesa #")]
        public int StandNumber { get; set; }
        [System.ComponentModel.DisplayName("Ubicacion")]

        public string Location { get; set; }
        [System.ComponentModel.DisplayName("Sillas")]
        public int seats { get; set; }
        [System.ComponentModel.DisplayName("Estatus")]
        public bool Status { get; set; }


    }
}