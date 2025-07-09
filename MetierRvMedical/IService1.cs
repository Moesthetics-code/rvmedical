using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MetierRvMedical.model;

namespace MetierRvMedical
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);
        [OperationContract]
        bool AddAgenda(Agenda agenda);
        [OperationContract]
        bool UpdateAgenda(Agenda agenda);
        [OperationContract]
        List<Agenda> GetListeAgenda();
        [OperationContract]
        Medecin GetMedecinbyId(int id);
        // === Patient ===
        [OperationContract]
        List<patient> GetPatients();

        [OperationContract]
        bool AddPatient(patient p);

        [OperationContract]
        bool UpdatePatient(patient p);

        [OperationContract]
        bool DeletePatient(int id);

        [OperationContract]
        patient GetPatientById(int id);
        [OperationContract]
        Utilisateur Connexion(string identifiant, string motDePasseHash);

        // TODO: ajoutez vos opérations de service ici
    }


    // Utilisez un contrat de données comme indiqué dans l'exemple ci-après pour ajouter les types composites aux opérations de service.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
