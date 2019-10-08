# Справочник по Pascal

## Типы переменных

### Целочисленные типы

Type | Minimum | Maximum | Size
--- | --- | --- | ---
Shortint, Character | -$80 | $7F | signed 8-bit
Byte | 0 | $FF | unsigned 8-bit
Smallint | -$8000 | $7FFF | signed 16-bit
Word | 0 | $FFFF | unsigned 16-bit
Longint, Integer | -$80000000 | $7FFFFFFF | signed 32-bit
Longword, Cardinal  | 0 | $FFFFFFFF | unsigned 32-bit
Int64 | -2^63 | 2^63 - 1 | signed 64-bit
QWord | 0 | 2^64 - 1 | unsigned 64-bit

### Числа с плавающей запятой

Type | Minimum | Maximum | Significant digits | Size
--- | --- | --- | ---
Real | platform | dependent | ??? | 32 or 64
Single | 1.5E-45 | 3.4E38 | 7-8 | 32
Double | 5.0E-324 | 1.7E308 | 15-16 | 64
Extended | 1.9E-4932 | 1.1E4932 | 19-20 | 80

### Другие Типы

Type | Values
--- | ---
boolean | true, false
string | any strings 'in single quotes'
