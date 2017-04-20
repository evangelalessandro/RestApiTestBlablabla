using System.ComponentModel.DataAnnotations;

namespace dbSqlDati.App_model
{
    
    public enum TipoCamion
    {
        generico,
        frigoGenerico,
        frigoPerCarne,
        frigoADueCamere,
        telonatoAlimentare,
        telonatoNonAlimentare,
        cassaRigidaAlluminioGenerico,
        cassaRigidaAlluminioAbbigliamento,
        cassaRigidaAlluminioOfficinaMeccanica,
        autocistirnaGasolioBenzina,
        autocistirnaLatte,
        autocistirnaCereali,
        autocistirnaCalce,
        autocistirnaCemento,
        treAssiDa100Tonnellate,
        dueAssiDaMenoDi100Tonnellate,
        treAssiDaCava,
        biga,
        caricoMacchine
    }
}