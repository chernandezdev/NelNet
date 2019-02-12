using System;
using System.Collections.Generic;
using System.Text;

namespace PetMatcher
{
    public class Constants
    {
        public const string jsonPet = @"{'Pets':[
          {
            'Name':'Garfield',
            'Classification':'Mammal',
                     'Type':'Cat'
                },
                {
            'Name':'Odie',
            'Classification':'Mammal',
                     'Type':'Dog'
                },
                {
            'Name':'Peter Parker',
            'Classification':'Arachnid',
                     'Type':'Spider'
                },
                {
            'Name':'Kaa',
            'Classification':'Reptile',
                     'Type':'Snake'
                },
                {
            'Name':'Nemo',
            'Classification':'Fish',
                     'Type':'Goldfish'
                },
                {
            'Name':'Alpha',
            'Classification':'Fish',
                     'Type':'Betta'
                },
                {
            'Name':'Splinter',
            'Classification':'Mammal',
                     'Type':'Rat'
                },
                {
            'Name':'Coco',
            'Classification':'Bird',
                     'Type':'Parrot'
                },
                {
            'Name':'Tweety',
            'Classification':'Bird',
                     'Type':'Canary'
                }
                ]}";
        public const string jsonPeople = @"{'People':[
          {
             'Name':'Dalinar',
             'PreferredClassifications':[
                'Mammal'
                  ],
                           'PreferredTypes':[
                'Snake'
                  ]
 
                },
                          {
             'Name':'Kaladin',
             'PreferredClassifications':[
                'Reptile',
                           'Bird'
                  ],
                           'PreferredTypes':[
                'Goldfish'
                  ]
 
                }
                ]}";
        public const string goodPet = "would be a good pet";
        public const string badPet = "would be a bad pet";
    }
}
