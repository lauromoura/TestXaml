```
# OmniXal - Library for loading XAML files
git clone git://github.com/OmniGUI/OmniXaml

# Pull Zafiro, needed by OmniXaml
cd OmniXaml
git submodule update --init
cd ..

# TizenFX
git clone git://github.com/Samsung/TizenFX

# Test application
git clone git://github.com/expertisesolutions/TestXaml
cd TestXaml
dotnet run
```

It also requires [NUI/DAli on Windows](https://walac.github.io/build-dali/).
