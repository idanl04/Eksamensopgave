VAR haveAccess = false

Har du noget ID jeg må se?
    ** [Høje hæle] Jeg har ikke mit ID med, men prøv at se mine høje hæle, jeg ser da gammel nok ud, ik?
    -> DeniedHøjeHæle
    ** [Makeup] Jeg har godt nok ikke lige fået det med i dag, men se lige min make-up, jeg er jo moden
    -> DeniedMakeUp
    ** [Durum] Hmm har det ikke lige med, men hvis du får den her durum, må jeg så ikke komme ind alligevel?
    -> BribeSucces


=== DeniedHøjeHæle ===
Den falder jeg ikke for, smut med dig
-> DONE

=== DeniedMakeUp ===
Du ligner en der er gået i din mors make-uptaske, tag hjem og kom igen når du er gammel nok
-> DONE

=== BribeSucces ===
Suk* så lad dog gå, smut ind med dig. Men det bliver imellem os..
~ haveAccess = true
-> DONE