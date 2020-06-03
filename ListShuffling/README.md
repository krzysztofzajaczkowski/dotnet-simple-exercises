
[![LinkedIn][linkedin-shield]][linkedin-url]

# List Shuffling

## Table of Contents

* [About](#about)
* [Configuration](#configuration)
* [Data Templates](#data-templates)
* [Usage](#usage)
* [Contact](#contact)

## About

Shuffling two lists from CSV/JSON/TXT file with one of chosen shuffle types, and saving output to another file of the same type.

## Configuration
All parameters are stored in appsettings.json file. Only one of these shuffle types can be used at once.
```
{
  "FileNames": {
    "FileType": "JSON/CSV/TXT",
    "InputFileName": "fileName.extensions",
    "OutputFileName": "fileName.extension"
  },
  "ShuffleType": {
    "OneByOneShuffle": 1,
    "RandomShuffle": 0 
  } 
}
```

## Data Templates

CSV and TXT files must have 2 lines, each contains one list, where elements delimiter is one of:
 ``,\t;<space>``
JSON file template looks like this:
```
{
	["a","b","c","d"],
	[5,4,3,2,1]
}
```

## Usage
Since all options are stored in config file, the only way to use this program is to simply execute it.
```
ListShuffling
```

## Contact
Krzysztof Zajączkowski - krzysztof.m.zajaczkowski@gmail.com

[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=flat-square&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/krzysztof-m-zajaczkowski/