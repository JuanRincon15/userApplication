DROP TABLE IF EXISTS "User";
DROP TABLE IF EXISTS "Municipality";
DROP TABLE IF EXISTS "Department";
DROP TABLE IF EXISTS "Country";


CREATE TABLE "Country"(
	"ID" SERIAL PRIMARY KEY,
	"Name" VARCHAR(255) NOT NULL
);

CREATE TABLE "Department" (
    "ID" SERIAL PRIMARY KEY,
    "Name" VARCHAR(255) NOT NULL,
	"CountryID" INT,
	CONSTRAINT fk_country
		FOREIGN KEY ("CountryID") REFERENCES "Country"("ID")
		ON DELETE SET NULL
);

CREATE TABLE "Municipality" (
    "ID" SERIAL PRIMARY KEY,
    "Name" VARCHAR(255) NOT NULL,
    "DepartmentID" INT,
    CONSTRAINT fk_department
      FOREIGN KEY ("DepartmentID") REFERENCES "Department"("ID")
      ON DELETE SET NULL
);

CREATE TABLE "User" (
    "ID" SERIAL PRIMARY KEY,
    "Name" VARCHAR(255) NOT NULL,
    "Phone" VARCHAR(15),
    "Address" TEXT,
    "MunicipalityID" INT,
    CONSTRAINT fk_municipality
      FOREIGN KEY ("MunicipalityID") REFERENCES "Municipality"("ID")
      ON DELETE SET NULL
);



