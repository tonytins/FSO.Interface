# FSO Interface

FSO Interface transforms FreeSO's public APIs into interfaces so varies components can be swapped without changing the underlining architecture.

## Compatibility

Due to a strict null-safety policy, some breaking changes had to be made.

- FSO Interface is based on .NET 6 and many models have been turned into records.
- Arrays and lists have been turned into ``IEnumerable``while ``KeyValuePairs<>`` has been replaced with ``IDictionary<>`` unless the original API mandates a method from a specified type.

### VMSerializable

``VMSerializable`` is actually an interface, despite lacking the ``I`` prefix, and is used all across the game's virtual machine. FSO Interface naturally incorporates this into its library but has split the interface into two, ``IVMSerializable`` and ``IVMDeserializable``, providing Read and R/W functionalities, respectfully. The ``IVMDeserializable`` interface is used within methods that would normally require ``VMSerializable``.

## License

I license this project under the MPL-v2.0 license - see [LICENSE](LICENSE) for details.
