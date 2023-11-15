﻿namespace PokemonBlazor.Data.Pokemon
{
    public class PokemonService
    {
        private static readonly Pokemon[] Pokemon = new[]
        {
            new Pokemon("001", "Bulbasaur", "Grass", "Poison", "Bulbasaur can be seen napping in bright sunlight. There is a seed on its back. By soaking up the sun’s rays, the seed grows progressively larger."),
            new Pokemon("002", "Ivysaur", "Grass", "Poison", "There is a bud on this Pokémon’s back. To support its weight, Ivysaur’s legs and trunk grow thick and strong. If it starts spending more time lying in the sunlight, it’s a sign that the bud will bloom into a large flower soon."),
            new Pokemon("003", "Venusaur", "Grass", "Poison", "There is a large flower on Venusaur’s back. The flower is said to take on vivid colors if it gets plenty of nutrition and sunlight. The flower’s aroma soothes the emotions of people."),
            new Pokemon("004", "Charmander", "Fire", "", "The flame that burns at the tip of its tail is an indication of its emotions. The flame wavers when Charmander is enjoying itself. If the Pokémon becomes enraged, the flame burns fiercely."),
            new Pokemon("005", "Charmeleon", "Fire", "", "Charmeleon mercilessly destroys its foes using its sharp claws. If it encounters a strong foe, it turns aggressive. In this excited state, the flame at the tip of its tail flares with a bluish white color."),
            new Pokemon("006", "Charizard", "Fire", "Flying", "Charizard flies around the sky in search of powerful opponents. It breathes fire of such great heat that it melts anything. However, it never turns its fiery breath on any opponent weaker than itself."),
            new Pokemon("007", "Squirtle", "Water", "", "Squirtle’s shell is not merely used for protection. The shell’s rounded shape and the grooves on its surface help minimize resistance in water, enabling this Pokémon to swim at high speeds."),
            new Pokemon("008", "Wartortle", "Water", "", "Its tail is large and covered with a rich, thick fur. The tail becomes increasingly deeper in color as Wartortle ages. The scratches on its shell are evidence of this Pokémon’s toughness as a battler."),
            new Pokemon("009", "Blastoise", "Water", "", "Blastoise has water spouts that protrude from its shell. The water spouts are very accurate. They can shoot bullets of water with enough accuracy to strike empty cans from a distance of over 160 feet."),
            new Pokemon("010", "Caterpie", "Bug", "", "Its body is soft and weak. In nature, its perpetual fate is to be seen by others as food."),
            new Pokemon("011", "Metapod", "Bug", "", "Its hard shell doesn’t crack a bit even if Pikipek pecks at it, but it will tip over, spilling out its insides."),
            new Pokemon("012", "Butterfree", "Bug", "Flying", "wers is its favorite food. In fields of flowers, it has heated battles with Cutiefly for territory."),
            new Pokemon("013", "Weedle", "Bug", "Poison", "Weedle has an extremely acute sense of smell. It is capable of distinguishing its favorite kinds of leaves from those it dislikes just by sniffing with its big red proboscis (nose)."),
            new Pokemon("014", "Kakuna", "Bug", "Poison", "Kakuna remains virtually immobile as it clings to a tree. However, on the inside, it is extremely busy as it prepares for its coming evolution. This is evident from how hot the shell becomes to the touch."),
            new Pokemon("015", "Beedrill", "Bug", "Poison", "Beedrill is extremely territorial. No one should ever approach its nest—this is for their own safety. If angered, they will attack in a furious swarm."),
            new Pokemon("016", "Pidgey", "Normal", "Flying", "Pidgey has an extremely sharp sense of direction. It is capable of unerringly returning home to its nest, however far it may be removed from its familiar surroundings."),
            new Pokemon("017", "Pidgeotto", "Normal", "Flying", "Pidgeotto claims a large area as its own territory. This Pokémon flies around, patrolling its living space. If its territory is violated, it shows no mercy in thoroughly punishing the foe with its sharp claws."),
            new Pokemon("018", "Pidgeot", "Normal", "Flying", "This Pokémon has a dazzling plumage of beautifully glossy feathers. Many Trainers are captivated by the striking beauty of the feathers on its head, compelling them to choose Pidgeot as their Pokémon."),
            new Pokemon("019", "Rattata", "Normal", "", "This Pokémon is common but hazardous. Its sharp incisors can easily cut right through hard wood."),
            new Pokemon("020", "Raticate", "Normal", "", "Its whiskers are essential for maintaining its balance. No matter how friendly you are, it will get angry and bite you if you touch its whiskers."),
            new Pokemon("021", "Spearow", "Normal", "Flying", "Due to its short wings, it can’t fly long distances. It wanders about restlessly and pecks at bug Pokémon."),
            new Pokemon("022", "Fearow", "Normal", "Flying", "In Alola, fish Pokémon are its prey. It can be seen circling above the ocean searching for food."),
            new Pokemon("023", "Ekans", "Poison", "", "The eggs of bird Pokémon are its favorite food. It swallows eggs whole, so sometimes an egg gets stuck, and Ekans faints."),
            new Pokemon("024", "Arbok", "Poison", "", "After stunning its opponents with the pattern on its stomach, it quickly wraps them up in its body and waits for them to stop moving."),
            new Pokemon("025", "Pikachu", "Electric", "", "While sleeping, it generates electricity in the sacs in its cheeks. If it’s not getting enough sleep, it will be able to use only weak electricity."),
            new Pokemon("026", "Raichu", "Electric", "", "Because so many Trainers like the way Pikachu looks, you don’t see this Pokémon very often."),
            new Pokemon("027", "Sandshrew", "Ground", "", "When its skin gets wrinkled from moisture, it heads for a volcano. It lies flat on a spot with a lot of geothermal heat and dries itself out."),
            new Pokemon("028", "Sandslash", "Ground", "", "Thanks to its thick claws, it’s good at climbing trees. There are plenty of Sandslash that park themselves in trees and go right to sleep."),
            new Pokemon("029", "Nidoran♀", "Poison", "", "Nidoran♀ has barbs that secrete a powerful poison. They are thought to have developed as protection for this small-bodied Pokémon. When enraged, it releases a horrible toxin from its horn."),
            new Pokemon("030", "Nidorina", "Poison", "", "When Nidorina are with their friends or family, they keep their barbs tucked away to prevent hurting each other. This Pokémon appears to become nervous if separated from the others."),
            new Pokemon("031", "Nidoqueen", "Poison", "Ground", "Nidoqueen’s body is encased in extremely hard scales. It is adept at sending foes flying with harsh tackles. This Pokémon is at its strongest when it is defending its young."),
            new Pokemon("032", "Nidoran♂", "Poison", "", "Nidoran♂ has developed muscles for moving its ears. Thanks to them, the ears can be freely moved in any direction. Even the slightest sound does not escape this Pokémon’s notice."),
            new Pokemon("033", "Nidorino", "Poison", "", "Nidorino has a horn that is harder than a diamond. If it senses a hostile presence, all the barbs on its back bristle up at once, and it challenges the foe with all its might."),
            new Pokemon("034", "Nidoking", "Poison", "Ground", "Nidoking’s thick tail packs enormously destructive power. With one swing, it can topple a metal transmission tower. Once this Pokémon goes on a rampage, there is no stopping it."),
            new Pokemon("035", "Clefairy", "Fairy", "", "Bathed in moonlight, its wings glow faintly. Without even flapping, Clefairy rises into the air, where it dances around."),
            new Pokemon("036", "Clefable", "Fairy", "", "Some scientists believe that it gazes intently at the sky on nights with a full moon because it’s homesick."),
            new Pokemon("037", "Vulpix", "Fire", "", "It manipulates balls of fire to catch its prey. If you raise one from when it’s young, it will grow close to you like a puppy Pokémon."),
            new Pokemon("038", "Ninetales", "Fire", "", "The flickering flames it spews from its mouth leave its opponents hypnotized. Then, this extremely intelligent Pokémon attacks."),
            new Pokemon("039", "Jigglypuff", "Normal", "Fairy", "The songs they sing are totally different depending on the region they live in. Some even sound like they’re shouting!"),
            new Pokemon("040", "Wigglytuff", "Normal", "Fairy", "When it gets angry, it inhales with all its might, and its body gradually inflates. Sometimes they can grow 20 times larger!"),
            new Pokemon("041", "Zubat", "Poison", "Flying", "Their skin is so thin that they’ll be burned if sunlight hits them. When it gets cold out, they gather together to warm one another’s bodies."),
            new Pokemon("042", "Golbat", "Poison", "Flying", "They can suck down over 10 ounces of blood in one go. They have been known to drink so much blood that they can no longer fly."),
            new Pokemon("043", "Oddish", "Grass", "Poison", "Oddish searches for fertile, nutrient-rich soil, then plants itself. During the daytime, while it is planted, this Pokémon’s feet are thought to change shape and become similar to the roots of trees."),
            new Pokemon("044", "Gloom", "Grass", "Poison", "From its mouth Gloom drips honey that smells absolutely horrible. Apparently, it loves the horrid stench. It sniffs the noxious fumes and then drools even more of its honey."),
            new Pokemon("045", "Vileplume", "Grass", "Poison", "Vileplume has the world’s largest petals. They are used to attract prey that are then doused with toxic spores. Once the prey are immobilized, this Pokémon catches and devours them."),
            new Pokemon("046", "Paras", "Bug", "Grass", "The mushrooms, known as tochukaso, are controlling the bug. Even if the bug bugs the mushrooms, they tell it to bug off."),
            new Pokemon("047", "Parasect", "Bug", "Grass", "Its poisonous spores are also used in traditional medicine. Apparently, spores produced in Alola are not of very good quality."),
            new Pokemon("048", "Venonat", "Bug", "Poison", "Venonat is said to have evolved with a coat of thin, stiff hair that covers its entire body for protection. It possesses large eyes that never fail to spot even minuscule prey."),
            new Pokemon("049", "Venomoth", "Bug", "Poison", "Venomoth is nocturnal—it is a Pokémon that only becomes active at night. Its favorite prey are small insects that gather around streetlights, attracted by the light in the darkness."),
            new Pokemon("050", "Diglett", "Ground", "", "Around their crops, farmers plant the kind of tree that Diglett like to eat as a way of getting Diglett to plow the fields for them."),
            new Pokemon("051", "Dugtrio", "Ground", "", "Dugtrio’s heads are sleek and smooth and incredibly hard. It can dig through any soil with its headbutts."),
            new Pokemon("052", "Meowth", "Normal", "", "It loves coins, so if you give it one, you can make friends with Meowth easily. But it’s fickle, so you can’t count on that friendship lasting."),
            new Pokemon("053", "Persian", "Normal", "", "This Pokémon is popular with rich people. It’s also targeted by hunters who are after the jewel in its forehead."),
            new Pokemon("054", "Psyduck", "Water", "", "It has been found that its brain cells are 10 times more active when Psyduck is experiencing a headache."),
            new Pokemon("055", "Golduck", "Water", "", "A professional swimmer, it can continue swimming for two days straight by waving its long tail skillfully."),
            new Pokemon("056", "Mankey", "Fighting", "", "If one gets angry, all the others around it will get angry, so silence is a rare visitor in a troop of Mankey."),
            new Pokemon("057", "Primeape", "Fighting", "", "The blood vessels in its brain are sturdier than those of other Pokémon, so it can stay healthy despite its constant raging."),
            new Pokemon("058", "Growlithe", "Fire", "", "It has lived alongside humans since ages ago. Its bones have been found in excavations of ruins from the Stone Age."),
            new Pokemon("059", "Arcanine", "Fire", "", "There are so many old tales about them that they’re called legendary Pokémon, but there are way more of them around than you’d expect."),
            new Pokemon("060", "Poliwag", "Water", "", "The direction of the swirl on their stomachs differs depending on where they live. Poliwag aficionados can tell them apart at a glance."),
            new Pokemon("061", "Poliwhirl", "Water", "", "Its health suffers when its skin dries out, so be sure to moisturize it diligently."),
            new Pokemon("062", "Poliwrath", "Water", "Fighting", "The muscles it has developed through swimming are thick and powerful. When it lands a square punch, it can turn huge boulders to dust."),
            new Pokemon("063", "Abra", "Psychic", "", "It can read others’ minds and will teleport away when danger approaches. You must clear your mind if you want to catch it."),
            new Pokemon("064", "Kadabra", "Psychic", "", "It possesses strong mental capabilities, but its psychic powers are halved when it’s not holding a silver spoon."),
            new Pokemon("065", "Alakazam", "Psychic", "", "If it trusts someone deeply, it will let them have one of its spoons. Anything you eat with that spoon is apparently delicious."),
            new Pokemon("066", "Machop", "Fighting", "", "It likes food that’s highly nutritious because its instincts drive it to build muscle efficiently."),
            new Pokemon("067", "Machoke", "Fighting", "", "A popular motif for sculptures, its incredibly well-developed muscles have captured the imagination of many an artist."),
            new Pokemon("068", "Machamp", "Fighting", "", "With four arms, it can attack and defend simultaneously. It’s said to have mastered every martial art in the world."),
            new Pokemon("069", "Bellsprout", "Grass", "Poison", "Bellsprout’s thin and flexible body lets it bend and sway to avoid any attack, however strong it may be. From its mouth, this Pokémon spits a corrosive fluid that melts even iron."),
            new Pokemon("070", "Weepinbell", "Grass", "Poison", "Weepinbell has a large hook on its rear end. At night, the Pokémon hooks on to a tree branch and goes to sleep. If it moves around in its sleep, it may wake up to find itself on the ground."),
            new Pokemon("071", "Victreebel", "Grass", "Poison", "Victreebel has a long vine that extends from its head. This vine is waved and flicked about as if it were an animal to attract prey. When an unsuspecting prey draws near, this Pokémon swallows it whole."),
            new Pokemon("072", "Tentacool", "Water", "Poison", "Its body is 99% water. The remaining 1% contains the organ that makes its poison."),
            new Pokemon("073", "Tentacruel", "Water", "Poison", "It communicates with others of its kind by lighting up the red orbs on its head. When the orbs are blinking, it’s a warning sign."),
            new Pokemon("074", "Geodude", "Rock", "Ground", "It uses both hands to climb precipitous cliffs. People who see it in action have been known to take up bouldering."),
            new Pokemon("075", "Graveler", "Rock", "Ground", "It travels by rolling down cliffs. If it falls into a river, it will explode with its last gasp."),
            new Pokemon("076", "Golem", "Rock", "Ground", "It detonates its own body. The power from that explosion can propel it up steep mountain paths with amazing speed."),
            new Pokemon("077", "Ponyta", "Fire", "", "Ponyta is very weak at birth. It can barely stand up. This Pokémon becomes stronger by stumbling and falling to keep up with its parent."),
            new Pokemon("078", "Rapidash", "Fire", "", "Rapidash usually can be seen casually cantering in the fields and plains. However, when this Pokémon turns serious, its fiery manes flare and blaze as it gallops its way up to 150 mph."),
            new Pokemon("079", "Slowpoke", "Water", "Psychic", "Although their tails, which fall off naturally, can easily be found lying around, they’re a precious ingredient for cooking."),
            new Pokemon("080", "Slowbro", "Water", "Psychic", "Shellder, in its greed to suck out more and more sweetness from Slowbro’s tail, has metamorphosed into a spiral-shaped shell."),
            new Pokemon("081", "Magnemite", "Electric", "Steel", "Perhaps because electrical lines are often buried these days, the number of Magnemite attacks on power plants has increased."),
            new Pokemon("082", "Magneton", "Electric", "Steel", "When rain clouds form, many Magneton gather in high places to wait for lightning to strike."),
            new Pokemon("083", "Farfetch'd", "Normal", "Flying", "Farfetch’d is always seen with a stalk from a plant of some sort. Apparently, there are good stalks and bad stalks. This Pokémon has been known to fight with others over stalks."),
            new Pokemon("084", "Doduo", "Normal", "Flying", "Doduo’s two heads contain completely identical brains. A scientific study reported that on rare occasions, there will be examples of this Pokémon possessing different sets of brains."),
            new Pokemon("085", "Dodrio", "Normal", "Flying", "Apparently, the heads aren’t the only parts of the body that Dodrio has three of. It has three sets of hearts and lungs as well, so it is capable of running long distances without rest."),
            new Pokemon("086", "Seel", "Water", "", "Thanks to its thick fat, cold seas don’t bother it at all, but it gets tired pretty easily in warm waters."),
            new Pokemon("087", "Dewgong", "Water", "Ice", "It sunbathes on the beach after meals. The rise in its body temperature helps its digestion."),
            new Pokemon("088", "Grimer", "Poison", "", "The wastewater coming from factories is clean these days, so Grimer have nothing to eat. They’re said to be on the verge of extinction."),
            new Pokemon("089", "Muk", "Poison", "", "Because they scatter germs everywhere, they’ve long been targeted for extermination, leading to a steep decline in their population."),
            new Pokemon("090", "Shellder", "Water", "", "Even when its shell is closed, its tongue still hangs out. If you give its tongue a good yank, the shock will cause Shellder to open its shell."),
            new Pokemon("091", "Cloyster", "Water", "Ice", "Slowpoke tails are its favorite food. It has even been known to come up on land to look for Slowpoke from time to time."),
            new Pokemon("092", "Gastly", "Ghost", "Poison", "Poisonous gas comprises 95% of its body. It’s said that the remaining 5% is made up of the souls of those who died from the gas."),
            new Pokemon("093", "Haunter", "Ghost", "Poison", "It’s dangerous to go outside alone on nights when you’re feeling sad. Haunter will catch you, and you won’t be able to go back home."),
            new Pokemon("094", "Gengar", "Ghost", "Poison", "Even your home isn’t safe. Gengar will lurk in whatever dark corner of a room it can find and wait for its chance to catch its prey."),
            new Pokemon("095", "Onix", "Rock", "Ground", "Onix has a magnet in its brain. It acts as a compass so that this Pokémon does not lose direction while it is tunneling. As it grows older, its body becomes increasingly rounder and smoother."),
            new Pokemon("096", "Drowzee", "Psychic", "", "It puts its prey to sleep and devours their dreams. It seems that bad dreams taste sour, so Drowzee doesn’t particularly like eating them."),
            new Pokemon("097", "Hypno", "Psychic", "", "There are some Hypno that assist doctors with patients who can’t sleep at night in hospitals."),
            new Pokemon("098", "Krabby", "Water", "", "Krabby live on beaches, burrowed inside holes dug into the sand. On sandy beaches with little in the way of food, these Pokémon can be seen squabbling with each other over territory."),
            new Pokemon("099", "Kingler", "Water", "", "Kingler has an enormous, oversized claw. It waves this huge claw in the air to communicate with others. However, because the claw is so heavy, the Pokémon quickly tires."),
            new Pokemon("100", "Voltorb", "Electric", "", "Voltorb is extremely sensitive—it explodes at the slightest of shocks. It is rumored that it was first created when a Poké Ball was exposed to a powerful pulse of energy."),
            new Pokemon("101", "Electrode", "Electric", "", "One of Electrode’s characteristics is its attraction to electricity. It is a problematical Pokémon that congregates mostly at electrical power plants to feed on electricity that has just been generated."),
            new Pokemon("102", "Exeggcute", "Grass", "Psychic", "Although they are the same size as other Exeggcute, the ones produced in Alola are quite heavy. Their shells are packed full."),
            new Pokemon("103", "Exeggutor", "Grass", "Psychic", "Each of its three heads has its own thoughts. When they want to go in different directions, Exeggutor becomes unable to move."),
            new Pokemon("104", "Cubone", "Ground", "", "It wears its mother’s skull on its head, so no one knows what its bare face looks like. However, it’s clear that it’s always crying."),
            new Pokemon("105", "Marowak", "Ground", "", "They thump their bones rhythmically to communicate among themselves. There are nearly 50 different rhythmic patterns."),
            new Pokemon("106", "Hitmonlee", "Fighting", "", "Hitmonlee’s legs freely contract and stretch. Using these springlike legs, it bowls over foes with devastating kicks. After battle, it rubs down its legs and loosens the muscles to overcome fatigue."),
            new Pokemon("107", "Hitmonchan", "Fighting", "", "Hitmonchan is said to possess the spirit of a boxer who had been working toward a world championship. This Pokémon has an indomitable spirit and will never give up in the face of adversity."),
            new Pokemon("108", "Lickitung", "Normal", "", "It licks filth clean with its tongue. Whatever it licks always stinks afterward, so whether it’s really clean is...questionable."),
            new Pokemon("109", "Koffing", "Poison", "", "Koffing embodies toxic substances. It mixes the toxins with raw garbage to set off a chemical reaction that results in a terribly powerful poison gas. The higher the temperature, the more gas is concocted by this Pokémon."),
            new Pokemon("110", "Weezing", "Poison", "", "Weezing alternately shrinks and inflates its twin bodies to mix together toxic gases inside. The more the gases are mixed, the more powerful the toxins become. The Pokémon also becomes more putrid."),
            new Pokemon("111", "Rhyhorn", "Ground", "Rock", "Rhyhorn’s brain is very small. It is so dense, while on a run it forgets why it started running in the first place. It apparently remembers sometimes if it demolishes something."),
            new Pokemon("112", "Rhydon", "Ground", "Rock", "Rhydon has a horn that serves as a drill. It is used for destroying rocks and boulders. This Pokémon occasionally rams into streams of magma, but the armor-like hide prevents it from feeling the heat."),
            new Pokemon("113", "Chansey", "Normal", "", "Because the eggs on their bellies have been overharvested by people in the past, the Chansey population remains very small."),
            new Pokemon("114", "Tangela", "Grass", "", "Tangela’s vines snap off easily if they are grabbed. This happens without pain, allowing it to make a quick getaway. The lost vines are replaced by newly grown vines the very next day."),
            new Pokemon("115", "Kangaskhan", "Normal", "", "You shouldn’t get close to the child when it’s playing outside its mother’s pouch. Its mother is always nearby watching over it."),
            new Pokemon("116", "Horsea", "Water", "", "If Horsea senses danger, it will reflexively spray a dense black ink from its mouth and try to escape. This Pokémon swims by cleverly flapping the fin on its back."),
            new Pokemon("117", "Seadra", "Water", "", "Seadra generates whirlpools by spinning its body. The whirlpools are strong enough to swallow even fishing boats. This Pokémon weakens prey with these currents, then swallows it whole."),
            new Pokemon("118", "Goldeen", "Water", "", "The way it swims along fluttering its dress-like fins has earned it the name “princess of the water.”"),
            new Pokemon("119", "Seaking", "Water", "", "To attract females, males dance on the river’s floor. The females gather around the male that dances most gracefully."),
            new Pokemon("120", "Staryu", "Water", "", "No number of injuries can bother Staryu. Its amazing regenerative powers return it to its previous state in half a day!"),
            new Pokemon("121", "Starmie", "Water", "Psychic", "It rotates its geometrically shaped body to swim through the water. It always seems to be sending out mysterious radio waves."),
            new Pokemon("122", "Mr. Mime", "Psychic", "Fairy", "It creates invisible walls with its pantomiming. If you don’t act impressed, it will attack you with a double slap!"),
            new Pokemon("123", "Scyther", "Bug", "Flying", "Some call it a ninja. Its movements— imperceptibly quick—are sufficient to cleave the air in two. It’s very popular in Alola."),
            new Pokemon("124", "Jynx", "Ice", "Psychic", "Its strange cries sound like human language. There are some musicians who compose songs for Jynx to sing."),
            new Pokemon("125", "Electabuzz", "Electric", "", "While it’s often blamed for power outages, the truth is the cause of outages is more often an error on the part of the electric company."),
            new Pokemon("126", "Magmar", "Fire", "", "The hotter the place, the better they feel. Magmar in Alola are said to be hardier than those in other areas."),
            new Pokemon("127", "Pinsir", "Bug", "", "Although it’s tough, it can’t handle cold well. When night falls, it buries itself in leafage and sleeps."),
            new Pokemon("128", "Tauros", "Normal", "", "The climate seems to be related to the reason Tauros in Alola are a little calmer than those in other regions."),
            new Pokemon("129", "Magikarp", "Water", "", "Thanks to their strong hold on life, dirty water doesn’t bother them at all. They live in waters all over the world!"),
            new Pokemon("130", "Gyarados", "Water", "Flying", "The energy from evolution stimulated its brain cells strongly, causing it to become very ferocious."),
            new Pokemon("131", "Lapras", "Water", "Ice", "They’ve been so cherished that there’s now an overabundance. The fish Pokémon population has declined in waters with too many Lapras."),
            new Pokemon("132", "Ditto", "Normal", "", "It transforms into whatever it sees. If the thing it’s transforming into isn’t right in front of it, Ditto relies on its memory—so sometimes it fails."),
            new Pokemon("133", "Eevee", "Normal", "", "Its genes are easily influenced by its surroundings. Even its face starts to look like that of its Trainer."),
            new Pokemon("134", "Vaporeon", "Water", "", "It detects nearby moisture with its fin. When its fin begins trembling rapidly, that means rain will fall in a few hours."),
            new Pokemon("135", "Jolteon", "Electric", "", "Its fur stands on end, becoming like needles it fires at enemies. Once they’re weakened, it finishes them off with a 10,000 volt shock."),
            new Pokemon("136", "Flareon", "Fire", "", "The flame chamber inside its body ignites when Flareon gets agitated, reaching temperatures of up to 1,650 degrees Fahrenheit."),
            new Pokemon("137", "Porygon", "Normal", "", "It was built 20 years ago by scientists who dreamed of exploring space. Their dreams have yet to come true."),
            new Pokemon("138", "Omanyte", "Rock", "Water", "It was restored from an ancient fossil. Those Helix Fossils are excavated from areas that were once oceans long, long ago."),
            new Pokemon("139", "Omastar", "Rock", "Water", "It wraps its prey in its tentacles to immobilize them and then finishes them off with its sharp fangs."),
            new Pokemon("140", "Kabuto", "Rock", "Water", "This Pokémon became extinct everywhere, except in a few areas. It protects itself with its hard shell."),
            new Pokemon("141", "Kabutops", "Rock", "Water", "It swims at speeds of roughly 29 knots, quickly closing in on its prey and slashing into them with its scythes to finish them off."),
            new Pokemon("142", "Aerodactyl", "Rock", "Flying", "It flew through the open skies over the ancient continent as if they were its own. When it touched ground, its walk was weak and slow."),
            new Pokemon("143", "Snorlax", "Normal", "", "It has no interest in anything other than eating. Even if you climb up on its stomach while it’s napping, it doesn’t seem to mind at all!"),
            new Pokemon("144", "Articuno", "Ice", "Flying", "Articuno is a legendary bird Pokémon that can control ice. The flapping of its wings chills the air. As a result, it is said that when this Pokémon flies, snow will fall."),
            new Pokemon("145", "Zapdos", "Electric", "Flying", "Zapdos is a legendary bird Pokémon that has the ability to control electricity. It usually lives in thunderclouds. The Pokémon gains power if it is stricken by lightning bolts."),
            new Pokemon("146", "Moltres", "Fire", "Flying", "Moltres is a legendary bird Pokémon that has the ability to control fire. If this Pokémon is injured, it is said to dip its body in the molten magma of a volcano to burn and heal itself."),
            new Pokemon("147", "Dratini", "Dragon", "", "It sheds its skin—almost on a daily basis—and grows larger. Its skin is soft just after it’s been shed."),
            new Pokemon("148", "Dragonair", "Dragon", "", "Some say that if you see it at the start of the year, flying through the sky and twisting its body, you’ll be healthy all year long."),
            new Pokemon("149", "Dragonite", "Dragon", "Flying", "You’ll often hear tales of this kindhearted Pokémon rescuing people or Pokémon that are drowning."),
            new Pokemon("150", "Mewtwo", "Psychic", "", "Mewtwo is a Pokémon that was created by genetic manipulation. However, even though the scientific power of humans created this Pokémon’s body, they failed to endow Mewtwo with a compassionate heart."),
            new Pokemon("151", "Mew", "Psychic", "", "Mew is said to possess the genetic composition of all Pokémon. It is capable of making itself invisible at will, so it entirely avoids notice even if it approaches people.")
        };

        public async Task<Pokemon[]> GetAllAsync()
        {
            await Task.Delay(2000);
            return await Task.FromResult(Pokemon);
        }
    }
}