CREATE OR REPLACE FUNCTION insert_municipality(p_name VARCHAR,department_id INT)
RETURNS INT AS $$
DECLARE
    new_id INT;
BEGIN
    INSERT INTO "Municipality" ("Name","DepartmentID") VALUES (p_name,department_id)
		RETURNING "ID" INTO new_id;
	RETURN new_id;
END;
$$ LANGUAGE plpgsql;
