namespace PulseNet.DataModelBindings.CDM;

public enum eSide
{
  NullSide = 0,
  Left     = 1,
  Right    = 2
}

public enum eGate
{
  NullGate = 0,
  Open     = 1,
  Closed   = 2
}

public enum eSwitch
{
  NullSwitch = 0,
  Off        = 1,
  On         = 2
}

public enum eCharge
{
  NullCharge = 0,
  Negative   = 1,
  Neutral    = 2,
  Positive   = 3
}

public enum eBreathState
{
  NoBreath                 = 0,
  PatientInitiatedInhale   = 1,
  PatientInitiatedPause    = 2,
  PatientInitiatedExhale   = 3,
  EquipmentInitiatedInhale = 4,
  EquipmentInitiatedPause  = 5,
  EquipmentInitiatedExhale = 6,
  ExpiratoryHold           = 7,
  InspiratoryHold          = 8,
}

public enum eDefaultType
{
  Model = 0,
  Zero  = 1
}

public enum eDriverWaveform
{
  NullDriverWaveform = 0,
  Square             = 1,
  AscendingRamp      = 2,
  DescendingRamp     = 3,
  ExponentialGrowth  = 4,
  ExponentialDecay   = 5,
  SinusoidalRise     = 6,
  SinusoidalFall     = 7,
  SigmoidalRise      = 8,
  SigmoidalFall      = 9
}
