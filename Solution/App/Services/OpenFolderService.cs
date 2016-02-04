﻿using System;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Pickers;
using App.Services.Contracts;

namespace App.Services
{
    public class OpenFolderService : IOpenFolderService
    {
        public async Task<StorageFolder> PromptAsync()
        {
            var folderPicker = new FolderPicker
                               {
                                   ViewMode = PickerViewMode.Thumbnail,
                                   SuggestedStartLocation = PickerLocationId.Desktop,
                                   FileTypeFilter = {"."}
                               };

            return await folderPicker.PickSingleFolderAsync();
        }
    }
}