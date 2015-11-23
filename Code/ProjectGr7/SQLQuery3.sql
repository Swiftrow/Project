CREATE TABLE ShoppingCart(
	IDShoppingCart int NOT NULL,
	ShoppingDate varchar(255),
	IDLP int NOT NULL,
	IDLB int NOT NULL,
	IDCust int NOT NULL,

	PRIMARY KEY (IDShoppingCart),
	FOREIGN KEY (IDLP) REFERENCES OrderLinePart(IDLP),
	FOREIGN KEY (IDLB) REFERENCES OrderLineBike(IDLB),
	FOREIGN KEY (IDCust) REFERENCES Customer(IDCust)

);