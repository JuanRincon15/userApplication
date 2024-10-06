CREATE OR REPLACE FUNCTION insert_municipality(p_name VARCHAR,department_id INT)
RETURNS VOID AS $$
BEGIN
    INSERT INTO "Municipality" ("Name","DepartmentID") VALUES (p_name,department_id);
END;
$$ LANGUAGE plpgsql;
