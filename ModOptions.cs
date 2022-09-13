using System.IO;
using Newtonsoft.Json;
using TinyLife;
using TinyLife.Mods;

namespace ExampleMod;

// a simple implementation of custom options for the example mod
public class ModOptions {

    public float DarkShirtSpeedIncrease = 2;

    // a simple save method for the mod options, which saves the current instance to the designated options file
    public void Save(ModInfo info) {
        ExampleMod.Logger.Info($"Saving options to {info.OptionsFile}");
        if (!info.OptionsFile.Directory.Exists)
            info.OptionsFile.Directory.Create();
        using var writer = new JsonTextWriter(info.OptionsFile.CreateText());
        SaveHandler.CreateSerializer(null).Serialize(writer, this);
    }

    // a simple loader for the mod options, which uses the designated options file given to us by the game
    // this method loads an instance of the options using a JSON loader and then returns it to be used in ExampleMod
    public static ModOptions Load(ModInfo info) {
        ExampleMod.Logger.Info($"Loading options from {info.OptionsFile}");
        if (info.OptionsFile.Exists) {
            using var reader = new JsonTextReader(info.OptionsFile.OpenText());
            return SaveHandler.CreateSerializer(null).Deserialize<ModOptions>(reader);
        } else {
            var ret = new ModOptions();
            ret.Save(info);
            return ret;
        }
    }

}
