Imports Newtonsoft.Json

Public Class DatiCovidRegione
    <JsonProperty("data")>
    Public Data As Date

    <JsonProperty("stato")>
    Public Stato As String

    <JsonProperty("codice_regione")>
    Public CodiceRegione As Integer

    <JsonProperty("denominazione_regione")>
    Public DenominazioneRegione As String

    <JsonProperty("lat")>
    Public Latitudine As Single

    <JsonProperty("long")>
    Public Longitudine As Single

    <JsonProperty("ricoverati_con_sintomi")>
    Public RicoveratiConSintomi As Integer

    <JsonProperty("terapia_intensiva")>
    Public TerapiaIntensiva As Integer

    <JsonProperty("totale_ospedalizzati")>
    Public TotaleOspedalizzati As Integer

    <JsonProperty("isolamento_domiciliare")>
    Public IsolamentoDomiciliare As Integer

    <JsonProperty("totale_positivi")>
    Public TotalePositivi As Integer

    <JsonProperty("variazione_totale_positivi")>
    Public VariazioneTotalePositivi As Integer

    <JsonProperty("nuovi_positivi")>
    Public NuoviPositivi As Integer

    <JsonProperty("dimessi_guariti")>
    Public DimessiGuariti As Integer

    <JsonProperty("deceduti")>
    Public Deceduti As Integer

    <JsonProperty("casi_da_sospetto_diagnostico")>
    Public CasiDaSospettoDiagnostico As String

    <JsonProperty("casi_da_screening")>
    Public CasiDaScreening As String

    <JsonProperty("totale_casi")>
    Public TotaleCasi As Integer

    <JsonProperty("tamponi")>
    Public Tamponi As Integer

    <JsonProperty("casi_testati")>
    Public CasiTestati As Integer

    <JsonProperty("note")>
    Public Note As String

    <JsonProperty("ingressi_terapia_intensiva")>
    Public IngressiTerapiaIntensiva As Integer

    <JsonProperty("note_test")>
    Public NoteTest As String

    <JsonProperty("note_casi")>
    Public NoteCasi As String

    <JsonProperty("totale_positivi_test_molecolare")>
    Public TotalePositiviTestMolecolare As Integer

    <JsonProperty("totale_positivi_test_antigenico_rapido")>
    Public TotalePositiviTestAntigenicoRapido As Integer

    <JsonProperty("tamponi_test_molecolare")>
    Public TamponiTestMolecolare As Integer

    <JsonProperty("tamponi_test_antigenico_rapido")>
    Public tamponiTestAntigenicoRapido As Integer

    <JsonProperty("codice_nuts_1")>
    Public CodiceNuts1 As String

    <JsonProperty("codice_nuts_2")>
    Public CodiceNuts2 As String


    Public Overrides Function ToString() As String
        Return DenominazioneRegione
    End Function

End Class