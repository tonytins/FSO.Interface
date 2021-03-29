# FSO Interface

This project turns FreeSO's public APIs into interfaces so varies components can be swaped without changing the underlining architecture. It does port over some of FreeSO's models, enums and structs in order to remain compatible.

## API Changes

Due to the nature of the library, some changes had to be made to the original API.

- FSO Interface is based on .NET 5 and many models have been turned into records.
- Many arrays and lists have been turned into ``IEnumerable``, unless the original API methods requires ``List<>``.
- ``KeyValuePairs<>`` has been replaced with ``IDictionary<>``.

### Interface conformity

- Any method that use to accept only a specific Iff implementation, now accepts any that implements ``IIffChunk`` interface.
- Any method that use to accept only a specific class based on ``IVMSerializable`` now only requires that it implement the interface itself.
- Any method that required a specific class with ``void Read(Stream stream)`` and ``void Write(Stream stream)``, such as the OTF and DBPF classes, now only requires that they implement ``IFileStream``, which carries the same methods.

Note that ``VMSerializable`` is one of the few cases where an interface has already been provided in FreeSO. It was simply been ported over to FSO Interface as ``IVMSerializable``.

## License

I license this project under the Apache-v2.0 license - see [LICENSE](LICENSE) for details.