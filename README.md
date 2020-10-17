# Bit Converter

Converts the numbers from one numerical system to another. Supports bases: 2, 8, 10, 16.

It works this way: Input A with base A1 is being converted to decimal D1. 
After that decimal D1 is being converted to designed base by division

## How number abstaction organized?

Number is represented as string: integer part, string: float part, int: base, separated by comma or dot.

## Supproted formats

- Binary
  - 101
  - "101."
  - 101.101
  - 101,101
  - 101,
  - .101
  - ,101

- Octal
  - 567
  - "567."
  - 567.765
  - 567,
  - 567,765
  - .567
  - ,567

- Decimal
  - 567
  - "567."
  - 567.765
  - 567,
  - 567,765
  - .567
  - ,567
  
- Hexadecimal (Separator dot always must follow explicitly)
  - AF.
  - AF.15
  - .AF
    


## To Do

- Cover with tests, sepatared by folders, named properly
  - Binary number tests for all formats
  - Octal number tests for all formats
  - Decimal number tests for all formats
  - Hexadecimal number tests for all formats

- Document functions with input format
- Create abstraction layers over Binary, Octal, Decimal, Hexadecimal numbers. Each partial case NumberModel(data, base).


