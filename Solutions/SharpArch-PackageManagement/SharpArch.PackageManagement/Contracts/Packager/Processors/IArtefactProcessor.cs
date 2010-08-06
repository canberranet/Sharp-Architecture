﻿namespace SharpArch.PackageManagement.Contracts.Packager.Processors
{
    using System.Collections.Generic;

    public interface IArtefactProcessor
    {
        IEnumerable<string> RetrieveDirectories(string path);

        IEnumerable<string> RetrieveFiles(string path);
    }
}