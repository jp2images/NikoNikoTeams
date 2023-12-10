# The making of a way to get the SBOM from the solution.
# This is a work in progress (WIP) and is primarily a learing experience.
#
#
#
# /<PackageReference/ {print $2, $3}
# /<PackageReference/ {split($2, ar1, "=") ; split($3, ar2, "=") ; print ar1[2], "v", ar2[2]}
# /<PackageReference/ {split($2, ar1, "=") ; split($3, ar2, "=") ; print ar1[2], ar2[1], ar2[2]}
# /<PackageReference/ {split($2, ar1, "=") ; split($3, ar2, "=") ; print ar1[2], ar2[1], ar2[2]}

# /<PackageReference/ { print $2, $3}
# match($0, /PackageReference Include=[^ ]*/, arr) {print arr[0]}

# Read in the csproj file and split it into tokens between the = sign and put each in an array
# Print the array cells for the NuGet name, and the version
#/<PackageReference/ {split($2, ar1, "=") ; split($3, ar2, "=") ; print ar1[2], ar2[2]}


# Look in the file for the delimiter <PackageReference as a literal pattern for regex.
# The result is split into tokens automatically labeled $1, $2, $3, etc. ($0 is the whole line)
# Split each concerned token further into tokens again on the = sign. Write the results into an 
# named array. 
# Print the output of the specific array cells. The previous cells [0] and [1] are only spaces.

/<PackageReference/ {
    split($2, ar1, "="); 
    split($3, ar2, "="); 
    split(ar1[2], name, "\""); 
    split(ar2[2], version, "\""); 
    print name[2], version[2]
    }