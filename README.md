ScriptCs.Coderbits
==================

ScriptCS script pack for querying the coderbits profile API

## Installation

Simply type:

    scriptcs -install ScriptCs.Coderbits

Or create packages.config:

    <?xml version="1.0" encoding="utf-8"?>
    <packages>
        <package id="ScriptCs.Coderbits" targetFramework="net45" />
    </packages>

And run:

    scriptcs -install
    
This will install `ScriptCs.Coderbits` and the necessary dependencies and copy them to a `bin` folder relative to the place from where you executed the installation.

## Usage

### Create the object

    var coderbits = Require<Coderbits>();

### Retrieve a profile

    var coderbitsModel = coderbits.GetProfile("scott");

### Retrieve a profile async

    var coderbitsModelTask = coderbits.GetProfileAsync("scott");

    //Do work

    var coderbitsModel = coderbitsModelTask.Result;

### Access profile members

    Console.WriteLine(coderbitsModel.name);

You can see all possible fields available in the profile model [here](https://github.com/scottksmith95/ScriptCs.Coderbits/blob/master/src/ScriptCs.Coderbits/CoderbitsModel.cs).

##License

The MIT License (MIT)

Copyright (c) 2013 Scott Smith

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.