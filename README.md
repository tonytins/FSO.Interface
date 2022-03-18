# FSO Interface

FSO Interface transforms FreeSO's public APIs into interfaces so varies components can be swapped without changing the underlining architecture.

## API Compatibility

Due to the nature of the library, some changes had to be made to the original API.

- FSO Interface is based on .NET 6 and many models have been turned into records.
- Many arrays and lists have been turned into ``IEnumerable``, unless the original API methods requires ``List<>``.
- ``KeyValuePairs<>`` has been replaced with ``IDictionary<>``.

### VMSerializable

Some classes are actually interfaces in FreeSO, such as ``VMSerializable``, despite lacking the ``I`` prefix. Naturally, FSO Interface incorporates this into its library but has split the interface into two, ``IVMSerializable`` and ``IVMDeserializable``, because not all classes implement both. For compatibility, the ``IVMDeserializable`` interface is used in inputs because it combines both Read and Write methods.

## License

I license this project under the MPL-v2.0 license - see [LICENSE](LICENSE) for details.
